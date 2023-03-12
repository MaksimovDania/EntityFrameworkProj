using DatabaseModels;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class CertificateRepository
    {
        private ApplicationContext database;

        public CertificateRepository()
        {
            database = new ApplicationContext();
        }
        public void Create(Certificates item)
        {
            if (item.Description == string.Empty)
                throw new ArgumentException("Certificate description not specified");
            if (database.Doctors.Where(par => par.Id == item.DoctorsId).Count() == 0)
                throw new KeyNotFoundException("There is no doctor with such Id");
            item.Doctors = database.Doctors.Where(par => par.Id == item.DoctorsId).FirstOrDefault();
            database.Certificates.Add(item);
            database.SaveChanges();
        }
        public void Delete(int id)
        {
            Certificates cer = database.Certificates.Where(par => par.Id == id).FirstOrDefault();
            database.Certificates.Remove(cer);
            database.SaveChanges();
        }
        public IEnumerable<Certificates> GetList()
        {
            List<Certificates> list;
            list = database.Certificates.ToList();
            return list;
        }
        public void Update(Certificates item)
        {
            if (database.Doctors.Where(par => par.Id == item.DoctorsId).Count() == 0)
                throw new KeyNotFoundException("There is no doctor with such Id");
            Certificates cer = database.Certificates.Where(par => par.Id == item.Id).FirstOrDefault();
            cer.DoctorsId = item.DoctorsId;
            cer.Description = item.Description;
            cer.Date = item.Date;
            database.Entry(cer).State = EntityState.Modified;
            database.SaveChanges();
        }
    }
}

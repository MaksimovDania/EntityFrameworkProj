using DatabaseModels;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class DoctorRepository
    {
        private ApplicationContext database;

        public DoctorRepository()
        {
            database = new ApplicationContext();
        }
        public void Create(Doctors item)
        {
            if (item.Name == string.Empty)
                throw new ArgumentException("Doctor name not specified");
            if (database.Specializations.Where(par => par.Id == item.SpecializationsId).Count() == 0)
                throw new KeyNotFoundException("There is no specialization with such Id");
            item.Specializations = database.Specializations.Where(par => par.Id == item.SpecializationsId).FirstOrDefault();
            database.Doctors.Add(item);
            database.SaveChanges();
        }
        public void Delete(int id)
        {
            Certificates cer = database.Certificates.Where(par => par.Id == id).FirstOrDefault();
            database.Certificates.Remove(cer);
            database.SaveChanges();
        }
        public IEnumerable<Doctors> GetList()
        {
            List<Doctors> list;
            list = database.Doctors.ToList();
            return list;
        }
        public void Update(Doctors item)
        {
            if (database.Specializations.Where(par => par.Id == item.SpecializationsId).Count() == 0)
                throw new KeyNotFoundException("There is no specialization with such Id");
            Doctors doc = database.Doctors.Where(par => par.Id == item.Id).FirstOrDefault();
            if (doc == null) throw new KeyNotFoundException("Not valid Id");
            doc.Name = item.Name;
            doc.SpecializationsId = item.SpecializationsId;
            database.Entry(doc).State = EntityState.Modified;
            database.SaveChanges();
        }
        public string GetSpecializationType(int docId)
        {
            var doctor = database.Doctors.Where(par => par.Id == docId).FirstOrDefault();
            var spec = database.Specializations.Where(par => par.Id == doctor.SpecializationsId).FirstOrDefault();
            return spec.Name;
        }

    }
}

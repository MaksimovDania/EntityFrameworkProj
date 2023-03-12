using DatabaseModels;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class Repository : IRepository
    {
        private ApplicationContext database;

        public Repository()
        {
            database = new ApplicationContext();
        }

        public void CreateCertificate(Certificates item)
        {
            if (item.Description == string.Empty)
                throw new ArgumentException("Certificate description not specified");
            if (database.Doctors.Where(par => par.Id == item.DoctorsId).Count() == 0)
                throw new KeyNotFoundException("There is no doctor with such Id");
            item.Doctors = database.Doctors.Where(par => par.Id == item.DoctorsId).FirstOrDefault();
            database.Certificates.Add(item);
            database.SaveChanges();
        }

        public void CreateDoctor(Doctors item)
        {
            if (item.Name == string.Empty)
                throw new ArgumentException("Doctor name not specified");
            if (database.Specializations.Where(par => par.Id == item.SpecializationsId).Count() == 0)
                throw new KeyNotFoundException("There is no specialization with such Id");
            item.Specializations = database.Specializations.Where(par => par.Id == item.SpecializationsId).FirstOrDefault();
            database.Doctors.Add(item);
            database.SaveChanges();
        }

        public void CreateSpecialization(Specializations item)
        {
            if (item.Name == string.Empty)
                throw new ArgumentException("Specialization name not specified");
            database.Specializations.Add(item);
            database.SaveChanges();
        }

        public void DeleteCertificates(int id)
        {
            Certificates cer = database.Certificates.Where(par => par.Id == id).FirstOrDefault();
            database.Certificates.Remove(cer);
            database.SaveChanges();
        }

        public void DeleteDoctors(int id)
        {
            Doctors doc = database.Doctors.Where(par => par.Id == id).FirstOrDefault();
            database.Doctors.Remove(doc);
            database.SaveChanges();
        }

        public void DeleteSpecializations(int id)
        {
            Specializations spec = database.Specializations.Where(par => par.Id == id).FirstOrDefault();
            database.Specializations.Remove(spec);
            database.SaveChanges();
        }

        public IEnumerable<Certificates> GetCertificatesList()
        {
            List<Certificates> list;
            list = database.Certificates.ToList();
            return list;
        }

        public IEnumerable<Doctors> GetDoctorsList()
        {
            List<Doctors> list;
            list = database.Doctors.ToList();
            return list;
        }

        public IEnumerable<Specializations> GetSpecializationsList()
        {
            List<Specializations> list;
            list = database.Specializations.ToList();
            return list;
        }

        public string GetSpecializationType(int docId)
        {
            var doctor = database.Doctors.Where(par => par.Id == docId).FirstOrDefault();
            var spec = database.Specializations.Where(par => par.Id == doctor.SpecializationsId).FirstOrDefault();
            return spec.Name;
        }

        public void UpdateCertificates(Certificates item)
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

        public void UpdateDoctors(Doctors item)
        {
            if (database.Specializations.Where(par => par.Id == item.SpecializationsId).Count() == 0)
                throw new KeyNotFoundException("There is no specialization with such Id");
            Doctors doc = database.Doctors.Where(par => par.Id == item.Id).FirstOrDefault();
            doc.Name = item.Name;
            doc.SpecializationsId = item.SpecializationsId;
            database.Entry(doc).State = EntityState.Modified;
            database.SaveChanges();
        }

        public void UpdateSpecializations(Specializations item)
        {
            if (item.Name == String.Empty)
                throw new ArgumentException("Specialization name not specified");
            Specializations spec = database.Specializations.Where(par => par.Id == item.Id).FirstOrDefault();
            spec.Name = item.Name;
            database.Entry(spec).State = EntityState.Modified;
            database.SaveChanges();
        }
    }
}
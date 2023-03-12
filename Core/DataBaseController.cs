using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;

namespace Core
{
    public class DataBaseController
    {
        private DoctorRepository _docrepository;
        private SpecializationRepository _specrepository;
        private CertificateRepository _cerrepository;

        public DataBaseController()
        {
            _docrepository = new DoctorRepository();
            _specrepository = new SpecializationRepository();
            _cerrepository = new CertificateRepository();
        }

        public void CreateSpecialization(string name)
        {
            var spec = new Specializations { Name = name };
            _specrepository.Create(spec);
        }

        public void CreateCertificate(int doctorId, string description, DateTime date)
        {
            var certificate = new Certificates {  DoctorsId = doctorId, Description = description, Date = date };
            _cerrepository.Create(certificate);
        }

        public void CreateDoctor(int specializationId, string name)
        {
            var doctor = new Doctors { SpecializationsId = specializationId, Name = name };
            _docrepository.Create(doctor);
        }

        public void DeleteCertificate(int id)
        {
            _cerrepository.Delete(id);
        }

        public void DeleteDoctor(int id)
        {
            _docrepository.Delete(id);
        }

        public void DeleteSpecialization(int id)
        {
            _specrepository.Delete(id);
        }

        public IEnumerable<Certificates> GetCertificatesList()
        {
            return _cerrepository.GetList();
        }

        public IEnumerable<Doctors> GetDoctorsList()
        {
            return _docrepository.GetList();
        }

        public IEnumerable<Specializations> GetSpecializationsList()
        {
            return _specrepository.GetList();
        }

        public void UpdateCertificates(int id, int doctorId, string description, DateTime date)
        {
            var certificate = new Certificates { Id = id, DoctorsId = doctorId, Description = description, Date = date };
            _cerrepository.Update(certificate);
        }

        public void UpdateDoctors(int id, int specializationId, string name)
        {
            var doctor = new Doctors { Id = id, SpecializationsId = specializationId, Name = name };
            _docrepository.Update(doctor);
        }

        public void UpdateSpecializations(int id, string name)
        {
            var spec = new Specializations { Id = id, Name = name };
            _specrepository.Update(spec);
        }

        public int NumberDoctorsWithSuchSpec(int id)
        {
            var doctors = GetDoctorsList();
            return (from d in doctors where d.SpecializationsId == id select d).Count();
        }

        public string GetSpecializationTypeForCertificate(int docId)
        {
            return _docrepository.GetSpecializationType(docId);
        }

        public DateTime GetLastCertificate(int docId)
        {
            var certificates = GetCertificatesList().Where(par => par.DoctorsId == docId).ToList();
            if (certificates.Count == 0)
                throw new Exception("The selected doctor has no certificates");
            return certificates.Max(c => c.Date);
        }
    }
}

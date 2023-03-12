using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;

namespace Core
{
    interface IRepository
    {
        IEnumerable<Certificates> GetCertificatesList(); // получение всех объектов
        IEnumerable<Doctors> GetDoctorsList();
        IEnumerable<Specializations> GetSpecializationsList();
        void CreateDoctor(Doctors item); // создание объекта
        void CreateSpecialization(Specializations item);
        void CreateCertificate(Certificates item);

        void UpdateDoctors(Doctors item); // обновление объекта
        void UpdateSpecializations(Specializations item);
        void UpdateCertificates(Certificates item);

        void DeleteDoctors(int id); // удаление объекта по id
        void DeleteSpecializations(int id);
        void DeleteCertificates(int id);

        string GetSpecializationType(int docId);
    }
}

using DatabaseModels;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    internal class SpecializationRepository
    {
        private ApplicationContext database;

        public SpecializationRepository()
        {
            database = new ApplicationContext();
        }
        public void Create(Specializations item)
        {
            if (item.Name == string.Empty)
                throw new ArgumentException("Specialization name not specified");
            database.Specializations.Add(item);
            database.SaveChanges();
        }
        public void Delete(int id)
        {
            Specializations spec = database.Specializations.Where(par => par.Id == id).FirstOrDefault();
            database.Specializations.Remove(spec);
            database.SaveChanges();
        }
        public IEnumerable<Specializations> GetList()
        {
            List<Specializations> list;
            list = database.Specializations.ToList();
            return list;
        }
        public void Update(Specializations item)
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

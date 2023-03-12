namespace DatabaseModels
{
    public class Doctors
    {
        public int Id { get; set; }

        public int SpecializationsId { get; set; }

        public string Name { get; set; }

        public Specializations? Specializations { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Certificates
    {
        public int Id { get; set; }

        public int DoctorsId { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public Doctors Doctors { get; set; }
    }
}

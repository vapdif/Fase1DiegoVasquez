using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1DiegoVasquez
{
    public class FormRegWD
    {
        private int id;
        private String fname, gender, position;
        private int wkDays, dayValue;
        private DateTime Date;

        // contructor
        public FormRegWD(int id, string fname, string gender, string position, int wkDays, int dayValue, DateTime date)
        {
            this.Id = id;
            this.fname = fname;
            this.Gender = gender;
            this.Position = position;
            this.WkDays = wkDays;
            this.DayValue = dayValue;
            Date1 = date;
        }

        // encapsulamos
        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Position { get => position; set => position = value; }
        public int WkDays { get => wkDays; set => wkDays = value; }
        public int DayValue { get => dayValue; set => dayValue = value; }
        public DateTime Date1 { get; set; }
    }
}

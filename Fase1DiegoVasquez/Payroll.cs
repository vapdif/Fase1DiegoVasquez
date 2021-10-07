using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1DiegoVasquez
{
    public class Payroll : FormRegWD
    {
        public Payroll(int id, string fname, string gender, string position, int wkDays, int dayValue, DateTime date) 
            : base(id, fname, gender, position, wkDays, dayValue, date)
        {
        }

        // metodo calcular Salario
        public int CalSalary(int wkDays, int dayValue)
        {
            int Tsalary = 0;
            Tsalary = (wkDays * dayValue);
            return Tsalary;
        }
    }
}

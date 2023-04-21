using EmployeApp.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeApp.Core.Models
{
    public class Employe : BaseModel
    {
        private static int _id;
        public string Name { get; set; }
        public string SurName { get; set; }
        public double Salary { get; set; }
        public Employe()
        {
            _id++;
            Id = _id;
        }


        public override string ToString()
        {
            return $"Id:" + Id + "   Name: " + Name + "  Surname: " + SurName + "    Salary: " + Salary;
        }
    }
}

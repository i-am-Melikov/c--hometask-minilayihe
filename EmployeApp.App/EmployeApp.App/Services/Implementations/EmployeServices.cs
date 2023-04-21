using EmployeApp.App.Services.Interfaces;
using EmployeApp.Core.Models;
using EmployeApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeApp.App.Services.Implementations
{
   
    internal class EmployeServices : IEmployeServices
    {
        public readonly EmployeRepository _employeRepository = new EmployeRepository();
        public void Create()
        {
            Employe employe = new Employe();
            Console.WriteLine("Add Name");
            employe.Name=Console.ReadLine();
            Console.WriteLine("Add SurName");
            employe.SurName = Console.ReadLine();
            Console.WriteLine("Add Salary");
            employe.Salary = double.Parse(Console.ReadLine());
            _employeRepository.Create(employe);
        }
        public void Update()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(), out int id);
            Employe employe = _employeRepository.ShowById(id);
            if (employe !=null)
            {
                Console.WriteLine("Enter new name");
                employe.Name = Console.ReadLine();
                Console.WriteLine("Enter new surname");
                employe.SurName = Console.ReadLine();
                Console.WriteLine("Enter new salary");
                employe.Salary= double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Employe not found");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(),out int id);
            Employe employe = _employeRepository.ShowById(id);
            if (employe != null)
            {
                _employeRepository.Delete(employe);
            }
            else
            {
                Console.WriteLine("Employe not found");
            }
        }
        public void DeleteAll()
        {
            if (_employeRepository != null)
            {
                _employeRepository.DeleteAll();
            }
            else
            {
                Console.WriteLine("Employe not found");
            }

        }
        public void ShowById()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(), out int id);
            Employe employe = _employeRepository.ShowById(id);
            if (employe != null)
            {
                Console.WriteLine(employe);
            }
            else
            {
                Console.WriteLine("Employe not found");
            }


        }
        public void ShowAll()
        {
            List<Employe> employes=_employeRepository.ShowAll();
            foreach(var  employe in employes)
            {
                Console.WriteLine(employe);
            }
        }
    }
}

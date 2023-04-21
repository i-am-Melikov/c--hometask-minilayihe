using EmployeApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeApp.App.Services.Interfaces
{
  
    public interface IEmployeServices
    {
        public void Create();
        public void Update();
        public void Delete();
        public void DeleteAll();
        public void ShowById();
        public void ShowAll();
    }
}

using EmployeApp.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeApp.Data.Repositories
{
    public class Repository<T> where T : BaseModel
    {
        
        private readonly List<T> _employes = new List<T>();
        public void Create(T NewEmploye) 
        {
            _employes.Add(NewEmploye);
        }
        public void Delete(T employe)
        {
            _employes.Remove(employe);
        }
        public void DeleteAll()
        {
            _employes.RemoveAll(x => x != null);
        }
        public T ShowById(int id)
        {
            foreach(var employe in _employes)
            {
                if(employe.Id==id)
                {
                    return employe;
                }
            }
            return null;
        }
        public List<T> ShowAll()
        {
            return _employes;
        }


    }
}

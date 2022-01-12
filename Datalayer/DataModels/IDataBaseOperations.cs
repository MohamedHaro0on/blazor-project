using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.DataModels
{
    public interface IDataBaseOperations
    {
        Task<List<Employee>> GetAllEmployees();
        Task<List<Employee>> GetEmployeeById(int em_id);
        Task<List<Employee>> GetEmployeeByName(string name);
        Task<bool> SaveEmployee(Employee newEmp);
    }
}

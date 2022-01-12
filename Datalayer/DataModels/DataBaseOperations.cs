using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.DataModels
{
    public class DataBaseOperations:IDataBaseOperations
    {
        private readonly ISQLDataAccess _db;
        public DataBaseOperations(ISQLDataAccess db)
        {
            _db = db;
        }
        async public Task<List<Employee>> GetAllEmployees()
        {
            string sql = "SELECT * from Employee ";
            return await _db.LoadData<Employee , dynamic>(sql , new { });
        }
        async public Task<List<Employee>> GetEmployeeById(int em_id)
        {
            string sql = "SELECT * from Employee where emp_id=" + em_id;
            return await _db.LoadData<Employee, dynamic>(sql, new { });
        }
        async public Task<List<Employee>> GetEmployeeByName(string name)
        {
            string sql = "SELECT * from Employee where emp_name like '%" + name + "%'";
            return await _db.LoadData<Employee, dynamic>(sql, new { });

        }
        async public Task<bool> SaveEmployee(Employee E)
        {
            try{
                string sql = "insert into Employee values (" + E.emp_id + ",'" + E.emp_name + "','" + E.emp_address + "','" + E.emp_photo_path + "')";
                await _db.LoadData<Employee, dynamic>(sql, E);
                return true;
            }
            catch (Exception ff)
            {
                return false;
            }
        }
    }
}

using Employee_JisaHW.Data;
using Employee_JisaHW.Models;

namespace Employee_JisaHW.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext db)
        {

            this.db = db;
        }


        public int AddEmploye(Employee employe)
        {
            db.Employees.Add(employe);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmploye(int id)
        {
            int res = 0;
            var result = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Employees.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Employee GetEmployeById(int id)
        {
            var result = db.Employees.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Employee> GetEmployes()
        {
            return db.Employees.ToList();
        }

        public int UpdateEmploye(Employee employe)
        {

            int res = 0;
            var result = db.Employees.Where(x => x.Id == employe.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = employe.Name;
                result.Salary = employe.Salary;
                result.City = employe.City;

                res = db.SaveChanges();
            }

            return res;
        }
    }
}

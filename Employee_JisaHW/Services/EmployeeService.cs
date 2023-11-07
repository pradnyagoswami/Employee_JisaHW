using Employee_JisaHW.Models;
using Employee_JisaHW.Repository;

namespace Employee_JisaHW.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;

        public EmployeeService(IEmployeeRepository repo)
        {

            this.repo = repo;
        }


        public int AddEmploye(Employee employe)
        {
            return repo.AddEmploye(employe);
        }

        public int DeleteEmploye(int id)
        {
            return repo.DeleteEmploye(id);
        }

        public Employee GetEmployeById(int id)
        {
            return repo.GetEmployeById(id);
        }

        public IEnumerable<Employee> GetEmployes()
        {
            return repo.GetEmployes();
        }

        public int UpdateEmploye(Employee employe)
        {
            return repo.UpdateEmploye(employe);
        }
    }
}

using Employee_JisaHW.Models;

namespace Employee_JisaHW.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployes();
        Employee GetEmployeById(int id);
        int AddEmploye(Employee employe);

        int UpdateEmploye(Employee employe);

        int DeleteEmploye(int id);
        
    }
}

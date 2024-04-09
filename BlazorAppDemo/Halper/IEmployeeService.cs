using ClassLibrary;

namespace BlazorAppDemo.Halper
{
    public interface IEmployeeService
    {
        Task<Employee> CreateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int id);
        Task<Employee> EditEmployee(int id);
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> UpdateEmployee(Employee employee, int id);
    }
}

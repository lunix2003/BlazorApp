using ClassLibrary;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorAppDemo.Halper
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient http;

        public EmployeeService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            var resp = await http.PostAsJsonAsync("Employee", employee);
            if(resp.IsSuccessStatusCode)
            {
                var emp = await resp.Content.ReadFromJsonAsync<Employee>();
                return emp!;
            }
            return null!;
        }

        public async Task<Employee> UpdateEmployee(Employee employee,int id)
        {
            var resp = await http.PutAsJsonAsync($"Employee/{id}", employee);
            if(resp.IsSuccessStatusCode)
            {
                var emp = await resp.Content.ReadFromJsonAsync<Employee>();
                return emp!;
            }
            return null!;


        }
        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await http.GetFromJsonAsync<Employee>($"Employee/{id}");
            return employee!;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await http.GetFromJsonAsync<IEnumerable<Employee>>($"Employee");
            return employees!;
        }
        public async Task<Employee> EditEmployee(int id)
        {
            var emp = await http!.GetFromJsonAsync<Employee>($"Employee/{id}");
            return emp!;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var resp = await http!.DeleteAsync($"Employee/{id}");
            if (resp.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        
    }
}

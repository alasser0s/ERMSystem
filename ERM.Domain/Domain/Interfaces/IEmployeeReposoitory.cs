using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERM.Domain.Domain.Interfaces
{
    public interface IEmployeeReposoitory : IRepository<Employee>
    {
       Task<Employee> GetByEmailAsync(string email);
       Task<IEnumerable<Employee>> GetByDepartmentIdAsync(int departmentId);
       Task<IEnumerable<Employee>> GetAvailableEmployeeAsync(DateTime StartDate , DateTime EndDate);
       Task<IEnumerable<Employee>> GetEmployeeByPositionAsync(int positionId);
        Task BulkUpdateStatusAsync(IEnumerable<int> employeeids, bool IsActive);


    }
}

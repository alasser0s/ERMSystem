using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERM.Domain.Domain.Interfaces
{
    public interface IAssetRepository : IRepository<Asset>
    {
Task<IEnumerable<Asset>> GetByStatusAsync(string status);

            Task<IEnumerable<Asset>> GetDueForMaintainanceAsync(DateTime startDate , DateTime endDate);
        Task<IEnumerable<Asset>> GetAsignedToEmployeeAsync(int employeeId);
        Task BulkUpdateStatusAsync(IEnumerable<int> assetIds, string status);
    }
}

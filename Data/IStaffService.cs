using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public interface IStaffService
    {
        Task StaffInsert(StaffInfo staff);
    }
}
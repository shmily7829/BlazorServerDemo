using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public interface IStaffService
    {
        Task<string> StaffInsert(StaffInfo staff);
    }
}
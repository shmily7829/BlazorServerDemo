using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public interface IStaffService
    {
        string StaffInsert(StaffInfo staff);
    }
}
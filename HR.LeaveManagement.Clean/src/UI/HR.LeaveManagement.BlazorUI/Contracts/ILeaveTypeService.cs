using HR.LeaveManagement.BlazorUI.Models.LeaveTypes;
using HR.LeaveManagement.BlazorUI.Services.Base;

namespace HR.LeaveManagement.BlazorUI.Contracts;

public interface ILeaveTypeService
{
    Task<List<LeaveTypeVM>> GetLeaveTypes();
    Task<LeaveTypeVM> GetLeaveTypeDetails(int id);
    Task<Response<Guid>> CreateLeavetype(LeaveTypeVM leaveType);
    Task<Response<Guid>> UpdateLeavetype(int id, LeaveTypeVM leaveType);
    Task<Response<Guid>> DeleteLeavetype(int id);
}

using System.ComponentModel.DataAnnotations;

namespace SCA_ITS_back_end.Models;

public class AddStaffRequest : BaseRequest
{
    public string? email { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string? password { get; set; }
}
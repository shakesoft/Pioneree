using PionereeDemo.Authorization.Users.Dto;

namespace PionereeDemo.Maui.Models.User;

public class UserListModel : UserListDto
{
    public string Photo { get; set; }

    public string FullName => Name + " " + Surname;
}
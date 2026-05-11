using WebApplication2.Models;
namespace WebApplication2.Services;

public class UserService : IUserService
{
    private readonly List<Users> _usersList;

    public UserService()
    {
        _usersList = new List<Users>()
        {
            new Users() {Id = 1, Name = "Diyor"},
            new Users() {Id = 2, Name = "Temur"},
            new Users() {Id = 3, Name = "Yusuf"}
        };
    }
    // Create
    public Users Create(Users user)
    {
        user.Id = _usersList.Count + 1;
        _usersList.Add(user);
        return user;
    }
    
    // Delete
    public Users Delete(int id)
    {
        var user = _usersList.FirstOrDefault(x => x.Id == id);
        if (user != null) _usersList.Remove(user);
        return user;
    }
    
    // GetAll
    public List<Users> GetAll()
    {
        return _usersList;
    }

    // Update
    public Users Update(Users updatedUser)
    {
        var user = _usersList.FirstOrDefault(x => x.Id == updatedUser.Id);
        if (user != null)
        {
            user.Name = updatedUser.Name;
        }

        return updatedUser;
    }
}
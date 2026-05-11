using WebApplication2.Models;
namespace WebApplication2.Services;

public interface IUserService
{
    // Create
    public Users Create(Users user);
    
    // Delete
    public Users Delete(int id);
    
    // GetAll
    public List<Users> GetAll();
    
    // Update
    public Users Update(Users updatedUser);
}
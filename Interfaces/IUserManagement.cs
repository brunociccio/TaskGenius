using System.Collections.Generic;
using TaskGenius.Models;

namespace TaskGenius.Interfaces
{
    public interface IUserManagement
    {
        // Interface criada para CRUD de usuários
        void AddUser(User user);
        void EditUser(int userId, User updatedUser);
        void DeleteUser(int userId);
        User GetUser(int userId);
        List<User> GetAllUsers();
    }
}

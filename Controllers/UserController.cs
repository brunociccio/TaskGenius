using Microsoft.AspNetCore.Mvc;
using TaskGenius.Models;
using System.Collections.Generic;

namespace TaskGenius.Controllers
{
    public class UserController : Controller
    {
        // Método de ação para exibir uma lista de usuários
        public IActionResult Index()
        {
            // Buscar todos os usuários cadastrados no sistema
            List<User> users = GetUsersFromDatabase();

            // Retorna uma view com a lista de usuários
            return View(users);
        }

        // Método auxiliar para simular a busca de usuários no banco de dados
        private List<User> GetUsersFromDatabase()
        {
            // Aqui você pode adicionar a lógica para buscar os usuários no banco de dados
            // Por enquanto, apenas retornaremos uma lista de usuários de exemplo
            List<User> users = new List<User>
            {
                new User(1, "user1", "password1", "User One"),
                new User(2, "user2", "password2", "User Two"),
                new User(3, "user3", "password3", "User Three")
            };

            return users;
        }

        // Método de ação para exibir detalhes de um usuário
        public IActionResult Details(int userId)
        {
            // Buscar o usuário com o ID fornecido
            User user = GetUserFromDatabase(userId);

            if (user == null)
            {
                return NotFound(); // Retorna uma resposta 404 se o usuário não for encontrado
            }

            return View(user); // Retorna uma view com os detalhes do usuário
        }

        // Método auxiliar para simular a busca de um usuário no banco de dados
        private User GetUserFromDatabase(int userId)
        {
            // Aqui você pode adicionar a lógica para buscar o usuário no banco de dados
            // Por enquanto, apenas retornaremos um usuário de exemplo
            // OBS: Não tem nenhum banco de dados conectado a esse projeto
            return new User(userId, "username", "password", "Full Name");
        }


        public IActionResult UserLogin()
        {
            return View("UserLogin");
        }
    }
}



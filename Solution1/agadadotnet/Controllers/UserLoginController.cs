using agadadotnet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace agadadotnet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        [HttpGet]
        public List<User> GetLogins()
        {
            List<User> users = new List<User>();
            using (var db = new AgadaContext())
            {
                users = db.Users.Include(r=>r.roles).ToList();

            }
            return users;
        }
        [HttpGet]

        public List<User> GetLoginWithRole()
        {
            List<User> list = new List<User>();
            using (var db = new AgadaContext())
            {
                list = db.Users.Include(role => role.roles).ToList();
            }
            return list;
        }

        [HttpGet]

        public User? GetLogin(int id)
        {
            User? log = new User();
            using (var db = new AgadaContext())
            {
                log = db.Users.Find(id);
            }
            return log;
        }

        [HttpPost]

        public User SaveUser(User user)
        {
            using (var db = new AgadaContext())
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                db.Users.Add(user);
                db.SaveChanges();
            }
            return user;
        }

        [HttpPost]
        public User CheckLogin(String username, String password)
        {
            User user;
            Console.WriteLine(password);
            using (var db = new AgadaContext())
            {
                user = db.Users.Where(u => u.Username == username).FirstOrDefault();
            }
            if (user != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {

                    return user;
                }
            }
            return user;
        }
        [HttpDelete]
        public string DeleteUser(int id)
        {
            User? user = new User();
            using (var db = new AgadaContext())
            {
                user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return "User deleted successfully!";
        }

        [HttpPut]

        public string UpdateUser(User user)
        {
            User? users = new User();
            using (var db = new AgadaContext())
            {
                users = db.Users.Find(user.UId);
                users.Username = user.Username;
                users.Password = user.Password;
                db.SaveChanges();
            }
            return "User updated successfully!";

        }

    }
}

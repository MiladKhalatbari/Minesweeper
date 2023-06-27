using Minesweeper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class UserRepository : IUserRepository
    {
        List<User> users = new List<User>();
        public UserRepository()
        {
            using (StreamReader sr = new StreamReader(Application.StartupPath + @"\DataBase.txt"))
            {
                string[] lines = sr.ReadToEnd().Split('\n');
                lines=lines.Take(lines.Count()-1).ToArray();
                foreach (string line in lines)
                {
                    string[] column = line.Split(',');
                    User user = new User();
                    user.Name = column[0];
                    user.Password = column[1];
                    user.Record = Convert.ToInt32(column[2]);
                    users.Add(user);
                }
            }
        }
        public void Delete(User user)
        {
            users.Remove(user);

        }

        public User Get(string name)
        {
            return users.First(x => x.Name == name);
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }

        public void Insert(User user)
        {
            users.Add(user);
        }

        public void Update(User user)
        {
            User u = users.First(x => x.Name == user.Name);
            users.Remove(u);
            users.Add(user);
        }
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\DataBase.txt"))
            {
                foreach (User user in users)
                {
                    sw.WriteLine($"{user.Name},{user.Password},{user.Record}");
                }
            }

        }
    }
}

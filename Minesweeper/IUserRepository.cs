using Minesweeper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public interface IUserRepository
    {
        void Update(User user);
        void Insert(User user);
        void Delete(User user);
        User Get (string name);
        void Save();
        IEnumerable<User> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    public class Database : IDatabase
    {
        public List<User>? users {get;}
        public void SaveUser(User user)
        {
            users!.Add(user);
        }
    }
}

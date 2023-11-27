using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtorizacia
{
    
        internal class User
        {
            public string name;
            public string login;
            public string password;
            public string sex;

            public User(string name, string login, string password, string sex)
            {
                this.name = name;
                this.login = login;
                this.password = password;
                this.sex = sex;
            }

        }
    }
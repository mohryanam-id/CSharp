using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class User
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;

        public User() {
            this._id = Guid.NewGuid().ToString();
            this._name = Guid.NewGuid().ToString();
            this._email = Guid.NewGuid().ToString();
            this._password = Guid.NewGuid().ToString();
        }

        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { set { _password = value; } }
    }
}

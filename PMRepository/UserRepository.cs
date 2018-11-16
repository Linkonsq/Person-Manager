using PMEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRepository
{
    public class UserRepository
    {
        private PersonDBContext context = new PersonDBContext();

        public bool Validate(User user)
        {
            User validUser = this.context.Users.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            return validUser != null;
        }
    }
}

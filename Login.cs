using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBALLayer
{
    public class Login
    {
        private string _username;
        public string Username
        {
            get {
                return _username;
            }
            set
            {
                if (value.Length>0)
                {
                    _username = value;
                }
                else
                {
                    throw new ArgumentNullException("Username cannot be null");
                }

            }
        }
        private string _pwd;
        public string Password
        {
            get { return _pwd; }
            set
            {
                if (value.Length>0)
                {
                    _pwd = value;
                }
                else
                {
                    throw new ArgumentNullException("Password cannot be null");
                }
            }
        }
    }
}

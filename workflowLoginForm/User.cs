using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflowLoginForm
{
    public class User
    {
        // Variables
        protected string username { get; set; }
        protected string password { get; set; }
        protected string job { get; set; }

        // Empty constructor
        public User ()
        {

        }

        // Constructor with values
        public User (string username, string password, string job)
        {
            this.username = username;
            this.password = password;
            this.job = job;
        }

        public User (string job)
        {
            this.job = job;
        }

        // Methods
        public string getUsername() { return username; }
        
        public string getPassword() { return password; }

        public string getJob() { return job; }

        // Clear values when logging out
        public void clearUser()
        {
            username = null;
            password = null;
            job = null;
        }

    }

}
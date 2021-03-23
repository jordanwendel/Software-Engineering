using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflowLoginForm
{
    class User
    {
        // Class level objects
        private DatabaseTools databaseTools;

        // Variables
        public string Username { get; set; }
        public string Password { get; set; }
        public string Job { get; set; }


        // Constructor for login
        public User (string username, string password)
        {
            databaseTools = new DatabaseTools();
            this.Username = username;
            this.Password = password;
            this.Job = databaseTools.GetJob(username); // Sets job from the database with given username
            databaseTools.CloseConnection();
        }

        /**
        public bool hasRole(string job)
        {
            if (this.Job.Equals(job))
            {
                return true;
            }

            return false;
        }
        */

    }

}
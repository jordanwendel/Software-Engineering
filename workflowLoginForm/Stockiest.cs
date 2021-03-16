using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflowLoginForm
{
    public class Stockiest : User
    {
        public Stockiest(string job) : base(job)
        {
            // Inherits user job from user class
        }

        // Log out
        public void logOut()
        {
            clearUser();
        }


    }
}


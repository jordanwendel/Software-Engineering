using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflowLoginForm
{
    public class QualityAnalyzer : User
    {
        public QualityAnalyzer(string job) : base(job)
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

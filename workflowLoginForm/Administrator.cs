using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflowLoginForm
{
    public class Administrator : User
    {
        public Administrator(string job) : base(job)
        {
            // Inherits user job from user class
        }


        private void editUser()
        {

        }
        
        // Log out
        public void logOut()
        {
            clearUser();
        }

        // Here is a list of functionality that the admin is allowed to do according to the requirement sheet

        /// MARK: REGISTRATION
        // Enter user details
        private void addNewUser(string username, string password, string job)
        {
            User user = new User(username, password, job);
        }

        // Select type of the user
        // Validate Details
        // Generate User ID, Password
        // Update Details
        // Login Generation


        /// MARK: STOCK MANAGEMENT
        // Login
        // View Stock Status
        // Add raw materials
        // Validate details
        // Generate ID
        // Update stock
        // View report


        /// MARK: PRODUCT MANAGEMENT
        /// Login
        /// View raw material stock
        /// Select items
        /// Validation
        /// Reduce stock of raw materials
        /// Re-order stock of raw materials
        /// Update stock status
        /// Manufacture product
        /// Generate ID for product
        /// Update product
        /// View report


        /// MARK: QUALITY ASSESSMENT
        /// Login
        /// View products
        /// Check product quality
        /// Update product status
        /// View report


        /// MARK: DELIVERY MANAGEMENT
        /// Login
        /// View the product
        /// Find qualified product
        /// Sales of qualified products
        /// Update stock details
        /// View report


        /// MARK: REPORT MANAGEMENT
        /// Login
        /// Raw materials report
        /// Product in progress report
        /// Qualified products report
        /// Defective products report


}
}

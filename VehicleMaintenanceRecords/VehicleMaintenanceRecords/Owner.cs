//Author: Josh Werlein
//Purpose: Create an application that tracks maintenance to vehicles by owner
//Date: 10/08/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace VehicleMaintenanceRecords
{
    internal class Owner
    {
        //Define class level variables
        private int mUserID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private string mPhoneNumber;
        private DateTime mRegistrationDate;

        //Establish a one to many relationship with the Vehicle class
        public List<Vehicle> Vehicles { get; set; }

        //Get and set variable values
        public int UserID { get { return mUserID; } set { mUserID = value; } }
        public string FirstName { get {  return mFirstName; } set {  mFirstName = value; } }
        public string LastName { get { return mLastName; } set { mLastName = value; } }
        public string Email { get { return mEmail; } set { mEmail = value; } }
        public string PhoneNumber { get {  return mPhoneNumber; } set { mPhoneNumber = value; } }   
        public DateTime RegistrationDate { get {  return mRegistrationDate; } set { mRegistrationDate = value; } }

        //Default constructor
        public Owner()
        {
            this.mUserID = 0;
            this.mFirstName = string.Empty;
            this.mLastName = string.Empty;
            this.mEmail = string.Empty;
            this.mPhoneNumber = string.Empty;
            this.mRegistrationDate = new DateTime(1901, 01, 01);
        }

        //Overloaded constructor
        public Owner(string firstName, string lastName)
        {
            this.mFirstName = firstName;
            this.mUserID = 0;
            this.mLastName= lastName;
            this.mEmail = string.Empty;
            this.mPhoneNumber = string.Empty;
            this.mRegistrationDate = new DateTime(1901, 01, 01);
        }

        //Overloaded constructor for UserID
        public Owner(int OwnerID)
        {
            mUserID = UserID;
            this.mFirstName = string.Empty;
            this.mLastName = string.Empty;
            this.mEmail = string.Empty;
            this.mPhoneNumber = string.Empty;
            this.mRegistrationDate = new DateTime(1901, 01, 01);
        }

        //Method for returning full name
        public string FullName()
        {
            return mFirstName + " " + mLastName;
        }
    }
}

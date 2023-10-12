//Author: Josh Werlein
//Purpose: Create an application that tracks maintenance to vehicles by owner
//Date: 10/08/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceRecords
{
    internal class Vehicle
    {
        //Declare class level variables
        private int mVehicleID;
        private string mMake;
        private string mModel;
        private int mYear;
        private string mColor;
        private string mVin;
        private string mLicensePlate;

        //Foreign key to associate with an owner
        public int UserID { get; set; }

        //Establish a relationship to Owner class
        public Owner Owner { get; set; }

        //Establish a one to many relationship with the Maintenance class
        public List<Maintenance> Maintenances { get; set; }

        //Get and set variable values
        public int VehicleID { get { return mVehicleID; } set {  mVehicleID = value; } }
        public string Make { get { return mMake; } set { mMake = value; } }
        public string Model { get { return mModel; } set { mModel = value; } }
        public int Year { get { return mYear; } set { mYear = value; } }
        public string Color { get { return mColor; } set { mColor = value; } }
        public string Vin { get {  return mVin; } set { mVin = value; } }
        public string LicensePlate { get {  return mLicensePlate; } set { mLicensePlate = value; } }

        //Default Constructor
        public Vehicle()
        {
            this.mVehicleID = 0;
            this.mMake = string.Empty;
            this.mModel = string.Empty;
            this.mYear = 0;
            this.mColor = string.Empty;
            this.mVin = string.Empty;
            this.mLicensePlate = string.Empty;
        }

        //Overloaded Constructor
        public Vehicle(int  VehicleID)
        {
            mVehicleID = VehicleID;
            this.mMake = string.Empty;
            this.mModel = string.Empty;
            this.mYear = 0;
            this.mColor = string.Empty;
            this.mVin = string.Empty;
            this.mLicensePlate = string.Empty;
        }
    }
}

//Author: Josh Werlein
//Purpose: Create an application that tracks maintenance to vehicles by owner
//Date: 10/08/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceRecords
{
    internal class Maintenance
    {
        //Declare class level variables
        private int mMaintenanceID;
        private int mOdometer;
        private decimal mCost;
        private string mNotes;
        private string mService;
        private DateTime mServiceDate;

        //Foreign key to associate with a vehicle
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

        //Get and set variable values
        public int MaintenanceID { get { return mMaintenanceID; } set { mMaintenanceID = value; } }
        public int Odometer { get { return mOdometer; } set { mOdometer = value; } }
        public decimal Cost { get { return mCost; } set { mCost = value; } }
        public string Notes { get { return mNotes; } set { mNotes = value; } }
        public string Service { get { return mService; } set { mService = value; } }
        public DateTime ServiceDate { get { return mServiceDate; } set { mServiceDate = value; } }

        //Default Constructor
        public Maintenance()
        {
            this.mMaintenanceID = 0;
            this.mOdometer = 0;
            this.mCost = 0;
            this.mNotes = string.Empty;
            this.mService = string.Empty;
            this.mServiceDate = new DateTime(1901, 01, 01);
        }

        //Overloaded Constructor
        public Maintenance(int MaintenanceID)
        {
            mMaintenanceID = MaintenanceID;
            this.mOdometer = 0;
            this.mCost = 0;
            this.mNotes = string.Empty;
            this.mService = string.Empty;
            this.mServiceDate = new DateTime(1901, 01, 01);
        }

    }
}

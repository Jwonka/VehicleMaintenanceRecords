//Author: Josh Werlein
//Purpose: Create an application that tracks maintenance to vehicles by owner
//Date: 10/08/2023

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;

namespace VehicleMaintenanceRecords
{
    public partial class VehicleMaintenanceRecordsForm : Form
    {
        public VehicleMaintenanceRecordsForm()
        {
            InitializeComponent();
        }

        //Create a selectedOwnerObject to reference which owner is selected in the listbox
        private Owner selectedOwnerObject;
        private Vehicle selectedVehicleObject;
        private Maintenance selectedMaintenanceObject;

        //Create a BindingList of Owners
        private BindingList<Owner> ownerList = new BindingList<Owner>();
        private BindingList<Vehicle> vehicleList = new BindingList<Vehicle>();
        private BindingList<Maintenance> maintenanceList = new BindingList<Maintenance>();

        //Class level Object - Owner, Vehicle, Maintenance
        private VehicleMaintenanceRecords.Owner ownerObject = new VehicleMaintenanceRecords.Owner();
        private VehicleMaintenanceRecords.Vehicle vehicleObject = new VehicleMaintenanceRecords.Vehicle();
        private VehicleMaintenanceRecords.Maintenance maintenanceObject = new VehicleMaintenanceRecords.Maintenance();

        //Declare class level variable
        int ownerLastNumber = 0;
        int vehicleLastNumber = 0;
        int maintenanceLastNumber = 0;

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Msg("CreateButton_Click method started.");
            //Declare Variables
            string selectedService = serviceCheckedListBox.Text;
            decimal costDecimalCheck;
            int odometerIntCheck;
            int yearIntCheck;
            DateTime registrationDateTime;
            DateTime serviceDateTime;

            //Declare new Owner, vehicle and Maintenance Objects
            var ownerObject = new Owner();
            var vehicleObject = new Vehicle();
            var maintenanceObject = new Maintenance();

            //Validate all input
            if (string.IsNullOrEmpty(this.firstNameTextBox.Text) || !this.firstNameTextBox.Text.All(char.IsLetter))
            {
                Msg("First name must be filled in with letters.");
                this.firstNameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(this.lastNameTextBox.Text) || !this.lastNameTextBox.Text.All(char.IsLetter))
            {
                Msg("Last name must be filled in with letters.");
                this.lastNameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                Msg("Email cannot be blank.");
                emailTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                Msg("Phone number cannot be blank.");
                phoneNumberTextBox.Focus();
                return;
            }
            else if (!DateTime.TryParse(registrationDateTimePicker.Text, out registrationDateTime))
            {
                Msg("Please enter a valid date.");
                registrationDateTimePicker.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(makeTextBox.Text) || !this.makeTextBox.Text.All(char.IsLetter))
            {
                Msg("Make must be filled in with letters.");
                makeTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(modelTextBox.Text))
            {
                Msg("Model cannot be blank.");
                modelTextBox.Focus();
                return;
            }
            else if (int.TryParse(yearTextBox.Text, out yearIntCheck) == false)
            {
                Msg("Year must be an integer.");
                yearTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(colorTextBox.Text) || !this.colorTextBox.Text.All(char.IsLetter))
            {
                Msg("Color must be filled in with letters.");
                colorTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(vinTextBox.Text))
            {
                Msg("Vin cannot be blank.");
                vinTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(licensePlateTextBox.Text))
            {
                Msg("License Plate cannot be blank.");
                licensePlateTextBox.Focus();
                return;
            }
            else if (int.TryParse(odometerTextBox.Text, out odometerIntCheck) == false)
            {
                Msg("Odometer must be an integer.");
                odometerTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(costTextBox.Text, out costDecimalCheck) == false)
            {
                Msg("Cost must be a decimal value.");
                costTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(notesTextBox.Text))
            {
                Msg("Notes can not be blank.");
                notesTextBox.Focus();
                return;
            }
            else if (!DateTime.TryParse(serviceDateTimePicker.Text, out serviceDateTime))
            {
                Msg("Please enter a valid date.");
                serviceDateTimePicker.Focus();
                return;
            }
            //Check if Service is selected
            else if (serviceCheckedListBox.SelectedIndex == -1)
            {
                Msg("Service must be selected.");
                this.serviceCheckedListBox.Focus();
                return;
            }
            //Update Primary Keys
            else
            {
                if (userIDTextBox.Text == String.Empty || vehicleIDTextBox.Text == String.Empty || maintenanceIDTextBox.Text == String.Empty)
                {
                    ownerLastNumber++;
                    ownerObject.UserID = ownerLastNumber;

                    vehicleLastNumber++;
                    vehicleObject.VehicleID = vehicleLastNumber;

                    maintenanceLastNumber++;
                    maintenanceObject.MaintenanceID = maintenanceLastNumber;
                }
                else
                {
                    ownerObject.UserID = int.Parse(userIDTextBox.Text);
                    vehicleObject.VehicleID = int.Parse(vehicleIDTextBox.Text);
                    maintenanceObject.MaintenanceID = int.Parse(maintenanceIDTextBox.Text);
                }
            }
            Msg("Validation completed successfully.");

            ownerObject.FirstName = firstNameTextBox.Text;
            ownerObject.LastName = lastNameTextBox.Text;
            ownerObject.Email = emailTextBox.Text;
            ownerObject.PhoneNumber = phoneNumberTextBox.Text;
            ownerObject.RegistrationDate = registrationDateTime;
            vehicleObject.Make = makeTextBox.Text;
            vehicleObject.Model = modelTextBox.Text;
            vehicleObject.Year = yearIntCheck;
            vehicleObject.Color = colorTextBox.Text;
            vehicleObject.Vin = vinTextBox.Text;
            vehicleObject.LicensePlate = licensePlateTextBox.Text;
            maintenanceObject.Odometer = odometerIntCheck;
            maintenanceObject.Cost = costDecimalCheck;
            maintenanceObject.Notes = notesTextBox.Text;
            maintenanceObject.Service = serviceCheckedListBox.SelectedItem.ToString();
            maintenanceObject.ServiceDate = serviceDateTime;
            int serviceIndex = serviceCheckedListBox.SelectedIndex;

            //Create a List for Services
            var serviceList = new List<decimal>();

            //Add Multipliers to list
            serviceList.Add(1.2m);
            serviceList.Add(1.3m);
            serviceList.Add(1.4m);
            serviceList.Add(1.5m);
            serviceList.Add(1.6m);
            serviceList.Add(1.7m);
            serviceList.Add(1.8m);
            serviceList.Add(1.9m);
            serviceList.Add(2.1m);
            serviceList.Add(2.2m);
            serviceList.Add(2.3m);
            serviceList.Add(2.4m);
            serviceList.Add(2.5m);
            serviceList.Add(2.6m);
            serviceList.Add(2.7m);
            serviceList.Add(2.8m);
            serviceList.Add(2.9m);
            serviceList.Add(3.1m);
            serviceList.Add(3.2m);
            serviceList.Add(3.3m);
            serviceList.Add(3.4m);
            serviceList.Add(3.5m);
            serviceList.Add(3.6m);
            serviceList.Add(3.7m);
            serviceList.Add(3.8m);
            serviceList.Add(3.9m);
            serviceList.Add(4.1m);
            serviceList.Add(4.2m);
            serviceList.Add(4.3m);
            serviceList.Add(4.4m);
            serviceList.Add(4.5m);

            decimal serviceMultiplier = serviceList[serviceCheckedListBox.SelectedIndex];
            decimal serviceCost = costDecimalCheck * serviceMultiplier;

            if (ownerObject != null || vehicleObject != null || maintenanceObject != null)
            {
                Msg("Creating new objects and inserting records.");
                ownerObject = new Owner();
                ownerLastNumber++;
                ownerObject.UserID = ownerLastNumber;
                ownerList.Add(ownerObject);

                vehicleObject = new Vehicle();
                vehicleLastNumber++;
                vehicleObject.VehicleID = vehicleLastNumber;
                vehicleList.Add(vehicleObject);

                maintenanceObject = new Maintenance();
                maintenanceLastNumber++;
                maintenanceObject.MaintenanceID = maintenanceLastNumber;
                maintenanceList.Add(maintenanceObject);
            }
            else
            {
                Msg("errorCreating new objects and inserting records.");
                ownerObject = new Owner();
                vehicleObject = new Vehicle();
                maintenanceObject = new Maintenance();
                return;
            }


            //Set object's to selectedUserObject for the binding list
            selectedOwnerObject = ownerObject;
            selectedVehicleObject = vehicleObject;
            selectedMaintenanceObject = maintenanceObject;

            ownerList.Add(ownerObject);
            vehicleList.Add(vehicleObject);
            maintenanceList.Add(maintenanceObject);

            ownerListBox.SelectedItem = ownerObject;
            vehicleListBox.SelectedItem = vehicleObject;
            maintenanceListBox.SelectedItem = maintenanceObject;
            Msg("Create completed.");
            InsertRecords();
            DisplayRecord();
        }

        private SqlConnection OpenDBConnection()
        {
            //Full path to bin/debug folder.
            string path = Application.StartupPath;
            int pathLength = path.Length;

            //Strip off the bin/debug folder to point  to the project folder
            path = path.Substring(0, pathLength - 25);

            //Create a connection string
            string connection = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + path + "VehicleMaintenanceRecords.mdf";

            //Create a connection Object to the database
            var dbConnection = new System.Data.SqlClient.SqlConnection(connection);

            //Open Database
            dbConnection.Open();

            return dbConnection;
        }

        private void ReloadOwners()
        {
            //Clear the Listbox
            ownerListBox.ClearSelected();

            //Open Database
            var connection = OpenDBConnection();

            //Create a Command Object
            var selectOwnerCommand = new SqlCommand("SELECT o.*, v.*, m.* " +
            "FROM [Owner_Tbl] o " +
            "LEFT JOIN [Vehicle_Tbl] v ON o.[UserID] = v.[UserID] " +
            "LEFT JOIN [Maintenance_Tbl] m ON v.[VehicleID] = m.[VehicleID];", connection);

            //Execute a Command into a DataReader
            var ownerReader = selectOwnerCommand.ExecuteReader();
            if (ownerReader.HasRows)
            {
                while (ownerReader.Read())
                {
                    var storedOwnerObject = new VehicleMaintenanceRecords.Owner((int)ownerReader["UserID"]);
                    storedOwnerObject.FirstName = ownerReader["FirstName"].ToString();
                    storedOwnerObject.LastName = ownerReader["LastName"].ToString();
                    storedOwnerObject.Email = ownerReader["Email"].ToString();
                    storedOwnerObject.PhoneNumber = ownerReader["PhoneNumber"].ToString();
                    storedOwnerObject.RegistrationDate = DateTime.Parse(ownerReader["RegistrationDate"].ToString());

                    //Update UserID
                    if (storedOwnerObject.UserID > ownerLastNumber)
                    {
                        ownerLastNumber = storedOwnerObject.UserID;
                    }
                    //Add Owner to the ownerList
                    ownerList.Add(storedOwnerObject);
                    Msg(storedOwnerObject.UserID.ToString());


                    //var vehicle = new VehicleMaintenanceRecords.Vehicle((int)ownerReader["VehicleID"]);
                    var VehicleID = ownerReader["VehicleID"];
                    if (VehicleID != DBNull.Value)
                    {
                        var vehicle = new VehicleMaintenanceRecords.Vehicle((int)VehicleID);
                        // Rest of your code to populate the vehicle object
                        vehicleList.Add(vehicle);
                        Msg(vehicle.VehicleID.ToString());

                        vehicle.Make = ownerReader["Make"].ToString();
                        vehicle.Model = ownerReader["Model"].ToString();
                        vehicle.Year = int.Parse(ownerReader["Year"].ToString());
                        vehicle.Color = ownerReader["Color"].ToString();
                        vehicle.Vin = ownerReader["Vin"].ToString();
                        vehicle.LicensePlate = ownerReader["LicensePlate"].ToString();

                        //Update VehicleID
                        if (vehicle.VehicleID > vehicleLastNumber)
                        {
                            vehicleLastNumber = vehicle.VehicleID;
                        }
                        //Add the vehicle to the vehicleList
                        vehicleList.Add(vehicle);
                        Msg(vehicle.VehicleID.ToString());
                    }
                    //var maintenance = new VehicleMaintenanceRecords.Maintenance((int)ownerReader["MaintenanceID"]);
                    var MaintenanceID = ownerReader["MaintenanceID"];
                    if (MaintenanceID != DBNull.Value)
                    {
                        var maintenance = new VehicleMaintenanceRecords.Maintenance((int)MaintenanceID);
                        // Rest of your code to populate the vehicle object
                        maintenanceList.Add(maintenance);
                        Msg(maintenance.MaintenanceID.ToString());

                        maintenance.Odometer = int.Parse(ownerReader["Odometer"].ToString());
                        maintenance.Cost = decimal.Parse(ownerReader["Cost"].ToString());
                        maintenance.Notes = ownerReader["Notes"].ToString();
                        maintenance.Service = ownerReader["Service"].ToString();
                        maintenance.ServiceDate = DateTime.Parse(ownerReader["ServiceDate"].ToString());

                        //Update MaintenanceID
                        if (maintenance.MaintenanceID > maintenanceLastNumber)
                        {
                            maintenanceLastNumber = maintenance.MaintenanceID;
                        }
                        //Add the maintenance record
                        maintenanceList.Add(maintenance);
                        Msg(maintenance.MaintenanceID.ToString());
                    }
                }
            }
            //Close the reader
            ownerReader.Close();
            connection.Close();
            connection.Dispose();
        }

        private void InsertRecords()
        {
            //Open Database
            var connection = OpenDBConnection();

            //Create SQL String 
            string ownerSQL = "INSERT INTO Owner_Tbl (FirstName, LastName, Email, PhoneNumber, RegistrationDate) " + "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @RegistrationDate); " + "SELECT SCOPE_IDENTITY();";
            Msg(ownerSQL.ToString());

            //Create Command
            var insertOwnerCommand = new SqlCommand(ownerSQL, connection);

            //Populate Parameters of the Insert
            insertOwnerCommand.Parameters.AddWithValue("@FirstName", ownerList.Last().FirstName);
            insertOwnerCommand.Parameters.AddWithValue("@LastName", ownerList.Last().LastName);
            insertOwnerCommand.Parameters.AddWithValue("@Email", ownerList.Last().Email);
            insertOwnerCommand.Parameters.AddWithValue("@PhoneNumber", ownerList.Last().PhoneNumber);
            insertOwnerCommand.Parameters.AddWithValue("@RegistrationDate", ownerList.Last().RegistrationDate);

            int intOwnerRowsAffected = insertOwnerCommand.ExecuteNonQuery();

            //Execute the insert and retrieve the generated UserID
            int ownerUserID = Convert.ToInt32(insertOwnerCommand.ExecuteScalar());

            //Create SQL String 
            string vehicleSQL = "INSERT INTO Vehicle_Tbl (UserID, Make, Model, Year, Color, Vin, LicensePlate) " + "VALUES (@UserID, @Make, @Model, @Year, @Color, @Vin, @LicensePlate); " + "SELECT SCOPE_IDENTITY();";
            Msg(vehicleSQL.ToString());

            //Create Command
            var insertVehicleCommand = new SqlCommand(vehicleSQL, connection);

            //Populate Parameters of the Insert
            insertVehicleCommand.Parameters.AddWithValue("@UserID", ownerUserID);
            insertVehicleCommand.Parameters.AddWithValue("@Make", vehicleList.Last().Make);
            insertVehicleCommand.Parameters.AddWithValue("@Model", vehicleList.Last().Model);
            insertVehicleCommand.Parameters.AddWithValue("@Year", vehicleList.Last().Year);
            insertVehicleCommand.Parameters.AddWithValue("@Color", vehicleList.Last().Color);
            insertVehicleCommand.Parameters.AddWithValue("@Vin", vehicleList.Last().Vin);
            insertVehicleCommand.Parameters.AddWithValue("@LicensePlate", vehicleList.Last().LicensePlate);

            int intVehicleRowsAffected = insertVehicleCommand.ExecuteNonQuery();

            int vehicleVehicleID = Convert.ToInt32(insertVehicleCommand.ExecuteScalar());

            //Create SQL String 
            string maintenanceSQL = "INSERT INTO Maintenance_Tbl (VehicleID, Odometer, Cost, Notes, Service, ServiceDate) " + "VALUES (@VehicleID, @Odometer, @Cost, @Notes, @Service, @ServiceDate);";
            Msg(maintenanceSQL.ToString());

            //Create Command
            var insertMaintenanceCommand = new SqlCommand(maintenanceSQL, connection);

            //Populate Parameters of the Insert
            insertMaintenanceCommand.Parameters.AddWithValue("@VehicleID", vehicleVehicleID);
            insertMaintenanceCommand.Parameters.AddWithValue("@Odometer", maintenanceList.Last().Odometer);
            insertMaintenanceCommand.Parameters.AddWithValue("@Cost", maintenanceList.Last().Cost);
            insertMaintenanceCommand.Parameters.AddWithValue("@Notes", maintenanceList.Last().Notes);
            insertMaintenanceCommand.Parameters.AddWithValue("@Service", maintenanceList.Last().Service);
            insertMaintenanceCommand.Parameters.AddWithValue("@ServiceDate", maintenanceList.Last().ServiceDate);
            
            int intMaintenanceRowsAffected = insertMaintenanceCommand.ExecuteNonQuery();


            if (intOwnerRowsAffected == 1 && intVehicleRowsAffected == 1 && intMaintenanceRowsAffected == 1)
            {
                Msg("Insertion successful.");
                Msg(ownerList.Last().FirstName + vehicleList.Last().Make + maintenanceList.Last().Cost + " was inserted.");
            }
            else
            {
                Msg("The insert failed.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            userIDTextBox.Text = string.Empty;
            vehicleIDTextBox.Text = string.Empty;
            maintenanceIDTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            makeTextBox.Text = string.Empty;
            modelTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            colorTextBox.Text = string.Empty;
            vinTextBox.Text = string.Empty;
            licensePlateTextBox.Text = string.Empty;
            odometerTextBox.Text = string.Empty;
            costTextBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;
            registrationDateTimePicker.Value = DateTime.Today;
            serviceDateTimePicker.Value = DateTime.Today;
            deleteCheckBox.Visible = false;
        }

        private void ownerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedOwner();
            if (ownerListBox.SelectedItem != null)
            {
                selectedOwnerObject = (Owner)ownerListBox.SelectedItem;
                selectedVehicleObject = (Vehicle)vehicleListBox.SelectedItem;
                selectedMaintenanceObject = (Maintenance)maintenanceListBox.SelectedItem;
                deleteCheckBox.Visible = true;
            }
            else
            {
                selectedOwnerObject = null;
                selectedVehicleObject = null;
                selectedMaintenanceObject = null;
                deleteCheckBox.Visible = false;
            }
        }

        private void ChangeSelectedOwner()
        {
            if (ownerListBox.SelectedItem is object)
            {
                selectedOwnerObject = (Owner)ownerListBox.SelectedItem;
                selectedVehicleObject = (Vehicle)vehicleListBox.SelectedItem;
                selectedMaintenanceObject = (Maintenance)maintenanceListBox.SelectedItem;
                DisplayRecord();
            }
            else
            {
                selectedOwnerObject = null;
                selectedVehicleObject = null;
                selectedMaintenanceObject = null;
                DisplayRecord();
            }
        }

        private void DisplayRecord()
        {
            //Populate Textboxes with the owner, vehicle, and maintenance records
            userIDTextBox.Text = selectedOwnerObject.UserID.ToString();
            vehicleIDTextBox.Text = selectedVehicleObject.VehicleID.ToString();
            maintenanceIDTextBox.Text = selectedMaintenanceObject.MaintenanceID.ToString();
            firstNameTextBox.Text = selectedOwnerObject.FirstName;
            lastNameTextBox.Text = selectedOwnerObject.LastName;
            emailTextBox.Text = selectedOwnerObject.Email;
            phoneNumberTextBox.Text = selectedOwnerObject.PhoneNumber;
            registrationDateTimePicker.Text = selectedOwnerObject.RegistrationDate.ToString();
            makeTextBox.Text = selectedVehicleObject.Make;
            modelTextBox.Text = selectedVehicleObject.Model;
            yearTextBox.Text = selectedVehicleObject.Year.ToString();
            colorTextBox.Text = selectedVehicleObject.Color;
            vinTextBox.Text = selectedVehicleObject.Vin;
            licensePlateTextBox.Text = selectedVehicleObject.LicensePlate;
            odometerTextBox.Text = selectedMaintenanceObject.Odometer.ToString();
            costTextBox.Text = selectedMaintenanceObject.Cost.ToString();
            notesTextBox.Text = selectedMaintenanceObject.Notes;
            serviceCheckedListBox.Text = selectedMaintenanceObject.Service;
            serviceDateTimePicker.Text = selectedMaintenanceObject.ServiceDate.ToString();
        }

        private void VehicleMaintenanceRecordsForm_Load(object sender, EventArgs e)
        {
            //Hide deleteCheckbox on load
            deleteCheckBox.Visible = false;

            //Set OwnerBinding List to Listbox
            ownerListBox.DataSource = ownerList;
            ownerListBox.DisplayMember = "FullName";
            vehicleListBox.DataSource = vehicleList;
            vehicleListBox.DisplayMember = "UserID";
            maintenanceListBox.DataSource = maintenanceList;
            maintenanceListBox.DisplayMember = "VehiclID";


            //Load Owners from the database
            ReloadOwners();
        }

        private void serviceCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }


        //Method to handle all MessageBox's
        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Customer Application", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void vehicleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
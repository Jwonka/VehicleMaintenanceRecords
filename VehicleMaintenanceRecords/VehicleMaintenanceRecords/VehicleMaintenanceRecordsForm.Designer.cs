namespace VehicleMaintenanceRecords
{
    partial class VehicleMaintenanceRecordsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ownerGroupBox = new GroupBox();
            registrationDateLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            registrationDateTimePicker = new DateTimePicker();
            phoneNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            userIDTextBox = new TextBox();
            userIDLabel = new Label();
            vehicleGroupBox = new GroupBox();
            licensePlateLabel = new Label();
            vinLabel = new Label();
            colorLabel = new Label();
            yearLabel = new Label();
            modelLabel = new Label();
            makeLabel = new Label();
            vehicleUserIDLabel = new Label();
            vehicleIDLabel = new Label();
            licensePlateTextBox = new TextBox();
            vinTextBox = new TextBox();
            colorTextBox = new TextBox();
            yearTextBox = new TextBox();
            modelTextBox = new TextBox();
            makeTextBox = new TextBox();
            vehicleUserIDTextBox = new TextBox();
            vehicleIDTextBox = new TextBox();
            maintenanceGroupBox = new GroupBox();
            serviceCheckedListBox = new CheckedListBox();
            serviceDateLabel = new Label();
            serviceLabel = new Label();
            notesLabel = new Label();
            costLabel = new Label();
            odometerLabel = new Label();
            maintenanceVehicleIDLabel = new Label();
            maintenanceLabel = new Label();
            serviceDateTimePicker = new DateTimePicker();
            notesTextBox = new TextBox();
            costTextBox = new TextBox();
            odometerTextBox = new TextBox();
            maintenanceVehicleIDTextBox = new TextBox();
            maintenanceIDTextBox = new TextBox();
            deleteCheckBox = new CheckBox();
            ownerListBox = new ListBox();
            ownerLabel = new Label();
            EditButton = new Button();
            ClearButton = new Button();
            CreateButton = new Button();
            vehicleListBox = new ListBox();
            maintenanceListBox = new ListBox();
            ownerGroupBox.SuspendLayout();
            vehicleGroupBox.SuspendLayout();
            maintenanceGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ownerGroupBox
            // 
            ownerGroupBox.BackColor = Color.DodgerBlue;
            ownerGroupBox.Controls.Add(registrationDateLabel);
            ownerGroupBox.Controls.Add(phoneNumberLabel);
            ownerGroupBox.Controls.Add(emailLabel);
            ownerGroupBox.Controls.Add(lastNameLabel);
            ownerGroupBox.Controls.Add(firstNameLabel);
            ownerGroupBox.Controls.Add(registrationDateTimePicker);
            ownerGroupBox.Controls.Add(phoneNumberTextBox);
            ownerGroupBox.Controls.Add(emailTextBox);
            ownerGroupBox.Controls.Add(lastNameTextBox);
            ownerGroupBox.Controls.Add(firstNameTextBox);
            ownerGroupBox.Controls.Add(userIDTextBox);
            ownerGroupBox.Controls.Add(userIDLabel);
            ownerGroupBox.Location = new Point(12, 12);
            ownerGroupBox.Name = "ownerGroupBox";
            ownerGroupBox.Size = new Size(322, 201);
            ownerGroupBox.TabIndex = 0;
            ownerGroupBox.TabStop = false;
            ownerGroupBox.Text = "Owner";
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Location = new Point(6, 170);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new Size(100, 15);
            registrationDateLabel.TabIndex = 11;
            registrationDateLabel.Text = "Registration Date:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(14, 141);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 15);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(66, 109);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(40, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(38, 54);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // registrationDateTimePicker
            // 
            registrationDateTimePicker.CalendarMonthBackground = Color.PeachPuff;
            registrationDateTimePicker.CustomFormat = "";
            registrationDateTimePicker.Location = new Point(111, 167);
            registrationDateTimePicker.Name = "registrationDateTimePicker";
            registrationDateTimePicker.Size = new Size(200, 23);
            registrationDateTimePicker.TabIndex = 6;
            registrationDateTimePicker.Value = new DateTime(2023, 10, 9, 0, 0, 0, 0);
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.PeachPuff;
            phoneNumberTextBox.Location = new Point(111, 138);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(200, 23);
            phoneNumberTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.PeachPuff;
            emailTextBox.Location = new Point(111, 106);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 23);
            emailTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.PeachPuff;
            lastNameTextBox.Location = new Point(111, 77);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.PeachPuff;
            firstNameTextBox.Location = new Point(111, 48);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // userIDTextBox
            // 
            userIDTextBox.BackColor = Color.PeachPuff;
            userIDTextBox.Enabled = false;
            userIDTextBox.Location = new Point(111, 19);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(200, 23);
            userIDTextBox.TabIndex = 1;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new Point(58, 22);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(47, 15);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "User ID:";
            // 
            // vehicleGroupBox
            // 
            vehicleGroupBox.BackColor = Color.DodgerBlue;
            vehicleGroupBox.Controls.Add(licensePlateLabel);
            vehicleGroupBox.Controls.Add(vinLabel);
            vehicleGroupBox.Controls.Add(colorLabel);
            vehicleGroupBox.Controls.Add(yearLabel);
            vehicleGroupBox.Controls.Add(modelLabel);
            vehicleGroupBox.Controls.Add(makeLabel);
            vehicleGroupBox.Controls.Add(vehicleUserIDLabel);
            vehicleGroupBox.Controls.Add(vehicleIDLabel);
            vehicleGroupBox.Controls.Add(licensePlateTextBox);
            vehicleGroupBox.Controls.Add(vinTextBox);
            vehicleGroupBox.Controls.Add(colorTextBox);
            vehicleGroupBox.Controls.Add(yearTextBox);
            vehicleGroupBox.Controls.Add(modelTextBox);
            vehicleGroupBox.Controls.Add(makeTextBox);
            vehicleGroupBox.Controls.Add(vehicleUserIDTextBox);
            vehicleGroupBox.Controls.Add(vehicleIDTextBox);
            vehicleGroupBox.Location = new Point(346, 11);
            vehicleGroupBox.Name = "vehicleGroupBox";
            vehicleGroupBox.Size = new Size(275, 256);
            vehicleGroupBox.TabIndex = 1;
            vehicleGroupBox.TabStop = false;
            vehicleGroupBox.Text = "Vehicle";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new Point(6, 224);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new Size(78, 15);
            licensePlateLabel.TabIndex = 17;
            licensePlateLabel.Text = "License Plate:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Location = new Point(52, 197);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(27, 15);
            vinLabel.TabIndex = 16;
            vinLabel.Text = "Vin:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(39, 168);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(39, 15);
            colorLabel.TabIndex = 15;
            colorLabel.Text = "Color:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(47, 140);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 14;
            yearLabel.Text = "Year:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(34, 110);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(44, 15);
            modelLabel.TabIndex = 13;
            modelLabel.Text = "Model:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(39, 80);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(39, 15);
            makeLabel.TabIndex = 12;
            makeLabel.Text = "Make:";
            // 
            // vehicleUserIDLabel
            // 
            vehicleUserIDLabel.AutoSize = true;
            vehicleUserIDLabel.Location = new Point(29, 51);
            vehicleUserIDLabel.Name = "vehicleUserIDLabel";
            vehicleUserIDLabel.Size = new Size(47, 15);
            vehicleUserIDLabel.TabIndex = 11;
            vehicleUserIDLabel.Text = "User ID:";
            // 
            // vehicleIDLabel
            // 
            vehicleIDLabel.AutoSize = true;
            vehicleIDLabel.Location = new Point(19, 22);
            vehicleIDLabel.Name = "vehicleIDLabel";
            vehicleIDLabel.Size = new Size(61, 15);
            vehicleIDLabel.TabIndex = 10;
            vehicleIDLabel.Text = "Vehicle ID:";
            // 
            // licensePlateTextBox
            // 
            licensePlateTextBox.BackColor = Color.PeachPuff;
            licensePlateTextBox.Location = new Point(86, 223);
            licensePlateTextBox.Name = "licensePlateTextBox";
            licensePlateTextBox.Size = new Size(178, 23);
            licensePlateTextBox.TabIndex = 9;
            // 
            // vinTextBox
            // 
            vinTextBox.BackColor = Color.PeachPuff;
            vinTextBox.Location = new Point(86, 196);
            vinTextBox.Name = "vinTextBox";
            vinTextBox.Size = new Size(178, 23);
            vinTextBox.TabIndex = 8;
            // 
            // colorTextBox
            // 
            colorTextBox.BackColor = Color.PeachPuff;
            colorTextBox.Location = new Point(86, 167);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(178, 23);
            colorTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.PeachPuff;
            yearTextBox.Location = new Point(86, 138);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(178, 23);
            yearTextBox.TabIndex = 6;
            // 
            // modelTextBox
            // 
            modelTextBox.BackColor = Color.PeachPuff;
            modelTextBox.Location = new Point(86, 109);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(178, 23);
            modelTextBox.TabIndex = 5;
            // 
            // makeTextBox
            // 
            makeTextBox.BackColor = Color.PeachPuff;
            makeTextBox.Location = new Point(86, 80);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(178, 23);
            makeTextBox.TabIndex = 4;
            // 
            // vehicleUserIDTextBox
            // 
            vehicleUserIDTextBox.BackColor = Color.PeachPuff;
            vehicleUserIDTextBox.Enabled = false;
            vehicleUserIDTextBox.Location = new Point(86, 51);
            vehicleUserIDTextBox.Name = "vehicleUserIDTextBox";
            vehicleUserIDTextBox.Size = new Size(178, 23);
            vehicleUserIDTextBox.TabIndex = 3;
            // 
            // vehicleIDTextBox
            // 
            vehicleIDTextBox.BackColor = Color.PeachPuff;
            vehicleIDTextBox.Enabled = false;
            vehicleIDTextBox.Location = new Point(86, 22);
            vehicleIDTextBox.Name = "vehicleIDTextBox";
            vehicleIDTextBox.Size = new Size(178, 23);
            vehicleIDTextBox.TabIndex = 2;
            // 
            // maintenanceGroupBox
            // 
            maintenanceGroupBox.BackColor = Color.DodgerBlue;
            maintenanceGroupBox.Controls.Add(serviceCheckedListBox);
            maintenanceGroupBox.Controls.Add(serviceDateLabel);
            maintenanceGroupBox.Controls.Add(serviceLabel);
            maintenanceGroupBox.Controls.Add(notesLabel);
            maintenanceGroupBox.Controls.Add(costLabel);
            maintenanceGroupBox.Controls.Add(odometerLabel);
            maintenanceGroupBox.Controls.Add(maintenanceVehicleIDLabel);
            maintenanceGroupBox.Controls.Add(maintenanceLabel);
            maintenanceGroupBox.Controls.Add(serviceDateTimePicker);
            maintenanceGroupBox.Controls.Add(notesTextBox);
            maintenanceGroupBox.Controls.Add(costTextBox);
            maintenanceGroupBox.Controls.Add(odometerTextBox);
            maintenanceGroupBox.Controls.Add(maintenanceVehicleIDTextBox);
            maintenanceGroupBox.Controls.Add(maintenanceIDTextBox);
            maintenanceGroupBox.Location = new Point(635, 12);
            maintenanceGroupBox.Name = "maintenanceGroupBox";
            maintenanceGroupBox.Size = new Size(340, 303);
            maintenanceGroupBox.TabIndex = 2;
            maintenanceGroupBox.TabStop = false;
            maintenanceGroupBox.Text = "Maintenance";
            // 
            // serviceCheckedListBox
            // 
            serviceCheckedListBox.BackColor = Color.PeachPuff;
            serviceCheckedListBox.FormattingEnabled = true;
            serviceCheckedListBox.Items.AddRange(new object[] { "Oil Change", "A/C System Inspection/Recharge", "Air Filter Replacement", "Ball Joint Replacement", "Battery Check/Replacement", "Brake Caliper Replacement", "Brake Fluid Flush", "Brake Inspection", "Brake Pad Replacement", "Coolant Flush", "Engine Diagnostic Scan", "Engine Tune-Up", "Fuel Filter Replacement", "Fuel Injector Cleaning", "Fuel Pump Replacement", "Oxygen Sensor Replacement", "Serpentine Belt Replacement", "Shock and Strut Replacement", "Spark Plug Replacement", "Suspension Check", "Suspension Service", "Thermostat Replacement", "Tie Rod End Replacement", "Timing Belt Replacement", "Tire Rotation", "Transmission Flush", "Transmission Service", "Wheel Alignment", "Wheel Balancing", "Wheel Bearing Replacement", "Wheel Hub Assembly Replacement" });
            serviceCheckedListBox.Location = new Point(129, 168);
            serviceCheckedListBox.Name = "serviceCheckedListBox";
            serviceCheckedListBox.Size = new Size(200, 76);
            serviceCheckedListBox.TabIndex = 16;
            // 
            // serviceDateLabel
            // 
            serviceDateLabel.AutoSize = true;
            serviceDateLabel.Location = new Point(42, 278);
            serviceDateLabel.Name = "serviceDateLabel";
            serviceDateLabel.Size = new Size(74, 15);
            serviceDateLabel.TabIndex = 15;
            serviceDateLabel.Text = "Service Date:";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(70, 203);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(47, 15);
            serviceLabel.TabIndex = 14;
            serviceLabel.Text = "Service:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(76, 140);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(41, 15);
            notesLabel.TabIndex = 13;
            notesLabel.Text = "Notes:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(83, 110);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(34, 15);
            costLabel.TabIndex = 12;
            costLabel.Text = "Cost:";
            // 
            // odometerLabel
            // 
            odometerLabel.AutoSize = true;
            odometerLabel.Location = new Point(52, 80);
            odometerLabel.Name = "odometerLabel";
            odometerLabel.Size = new Size(64, 15);
            odometerLabel.TabIndex = 11;
            odometerLabel.Text = "Odometer:";
            // 
            // maintenanceVehicleIDLabel
            // 
            maintenanceVehicleIDLabel.AutoSize = true;
            maintenanceVehicleIDLabel.Location = new Point(55, 50);
            maintenanceVehicleIDLabel.Name = "maintenanceVehicleIDLabel";
            maintenanceVehicleIDLabel.Size = new Size(61, 15);
            maintenanceVehicleIDLabel.TabIndex = 10;
            maintenanceVehicleIDLabel.Text = "Vehicle ID:";
            // 
            // maintenanceLabel
            // 
            maintenanceLabel.AutoSize = true;
            maintenanceLabel.Location = new Point(23, 23);
            maintenanceLabel.Name = "maintenanceLabel";
            maintenanceLabel.Size = new Size(93, 15);
            maintenanceLabel.TabIndex = 9;
            maintenanceLabel.Text = "Maintenance ID:";
            // 
            // serviceDateTimePicker
            // 
            serviceDateTimePicker.CalendarMonthBackground = Color.PeachPuff;
            serviceDateTimePicker.Location = new Point(129, 272);
            serviceDateTimePicker.Name = "serviceDateTimePicker";
            serviceDateTimePicker.Size = new Size(200, 23);
            serviceDateTimePicker.TabIndex = 7;
            serviceDateTimePicker.Value = new DateTime(2023, 10, 9, 0, 0, 0, 0);
            // 
            // notesTextBox
            // 
            notesTextBox.BackColor = Color.PeachPuff;
            notesTextBox.Location = new Point(129, 139);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(200, 23);
            notesTextBox.TabIndex = 6;
            // 
            // costTextBox
            // 
            costTextBox.BackColor = Color.PeachPuff;
            costTextBox.Location = new Point(129, 109);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(200, 23);
            costTextBox.TabIndex = 5;
            // 
            // odometerTextBox
            // 
            odometerTextBox.BackColor = Color.PeachPuff;
            odometerTextBox.Location = new Point(129, 78);
            odometerTextBox.Name = "odometerTextBox";
            odometerTextBox.Size = new Size(200, 23);
            odometerTextBox.TabIndex = 4;
            // 
            // maintenanceVehicleIDTextBox
            // 
            maintenanceVehicleIDTextBox.BackColor = Color.PeachPuff;
            maintenanceVehicleIDTextBox.Enabled = false;
            maintenanceVehicleIDTextBox.Location = new Point(129, 50);
            maintenanceVehicleIDTextBox.Name = "maintenanceVehicleIDTextBox";
            maintenanceVehicleIDTextBox.Size = new Size(200, 23);
            maintenanceVehicleIDTextBox.TabIndex = 3;
            // 
            // maintenanceIDTextBox
            // 
            maintenanceIDTextBox.BackColor = Color.PeachPuff;
            maintenanceIDTextBox.Enabled = false;
            maintenanceIDTextBox.Location = new Point(129, 22);
            maintenanceIDTextBox.Name = "maintenanceIDTextBox";
            maintenanceIDTextBox.Size = new Size(200, 23);
            maintenanceIDTextBox.TabIndex = 2;
            // 
            // deleteCheckBox
            // 
            deleteCheckBox.AutoSize = true;
            deleteCheckBox.Location = new Point(235, 260);
            deleteCheckBox.Name = "deleteCheckBox";
            deleteCheckBox.Size = new Size(99, 19);
            deleteCheckBox.TabIndex = 3;
            deleteCheckBox.Text = "Delete Record";
            deleteCheckBox.UseVisualStyleBackColor = true;
            deleteCheckBox.CheckedChanged += deleteCheckBox_CheckedChanged;
            // 
            // ownerListBox
            // 
            ownerListBox.BackColor = Color.PeachPuff;
            ownerListBox.FormattingEnabled = true;
            ownerListBox.ItemHeight = 15;
            ownerListBox.Location = new Point(12, 290);
            ownerListBox.Name = "ownerListBox";
            ownerListBox.Size = new Size(322, 124);
            ownerListBox.TabIndex = 4;
            ownerListBox.SelectedIndexChanged += ownerListBox_SelectedIndexChanged;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new Point(12, 267);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(50, 15);
            ownerLabel.TabIndex = 5;
            ownerLabel.Text = "Owners:";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Orange;
            EditButton.Location = new Point(259, 219);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Red;
            ClearButton.Location = new Point(127, 219);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.SeaGreen;
            CreateButton.Location = new Point(12, 219);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 9;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // vehicleListBox
            // 
            vehicleListBox.BackColor = Color.PeachPuff;
            vehicleListBox.FormattingEnabled = true;
            vehicleListBox.ItemHeight = 15;
            vehicleListBox.Location = new Point(346, 290);
            vehicleListBox.Name = "vehicleListBox";
            vehicleListBox.Size = new Size(275, 124);
            vehicleListBox.TabIndex = 10;
            vehicleListBox.SelectedIndexChanged += vehicleListBox_SelectedIndexChanged;
            // 
            // maintenanceListBox
            // 
            maintenanceListBox.BackColor = Color.PeachPuff;
            maintenanceListBox.FormattingEnabled = true;
            maintenanceListBox.ItemHeight = 15;
            maintenanceListBox.Location = new Point(635, 320);
            maintenanceListBox.Name = "maintenanceListBox";
            maintenanceListBox.Size = new Size(340, 94);
            maintenanceListBox.TabIndex = 11;
            // 
            // VehicleMaintenanceRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(990, 421);
            Controls.Add(maintenanceListBox);
            Controls.Add(vehicleListBox);
            Controls.Add(CreateButton);
            Controls.Add(ClearButton);
            Controls.Add(EditButton);
            Controls.Add(ownerLabel);
            Controls.Add(ownerListBox);
            Controls.Add(deleteCheckBox);
            Controls.Add(maintenanceGroupBox);
            Controls.Add(vehicleGroupBox);
            Controls.Add(ownerGroupBox);
            Name = "VehicleMaintenanceRecordsForm";
            Text = "Vehicle Maintenance Records";
            Load += VehicleMaintenanceRecordsForm_Load;
            ownerGroupBox.ResumeLayout(false);
            ownerGroupBox.PerformLayout();
            vehicleGroupBox.ResumeLayout(false);
            vehicleGroupBox.PerformLayout();
            maintenanceGroupBox.ResumeLayout(false);
            maintenanceGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ownerGroupBox;
        private GroupBox vehicleGroupBox;
        private GroupBox maintenanceGroupBox;
        private CheckBox deleteCheckBox;
        private ListBox ownerListBox;
        private Label ownerLabel;
        private Button EditButton;
        private Button ClearButton;
        private Button CreateButton;
        private TextBox userIDTextBox;
        private Label userIDLabel;
        private TextBox vehicleUserIDTextBox;
        private TextBox vehicleIDTextBox;
        private TextBox maintenanceVehicleIDTextBox;
        private TextBox maintenanceIDTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox licensePlateTextBox;
        private TextBox vinTextBox;
        private TextBox colorTextBox;
        private TextBox yearTextBox;
        private TextBox modelTextBox;
        private TextBox makeTextBox;
        private TextBox notesTextBox;
        private TextBox costTextBox;
        private TextBox odometerTextBox;
        private DateTimePicker registrationDateTimePicker;
        private DateTimePicker serviceDateTimePicker;
        private ComboBox maintenanceTypComboBox;
        private Label registrationDateLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label licensePlateLabel;
        private Label vinLabel;
        private Label colorLabel;
        private Label yearLabel;
        private Label modelLabel;
        private Label makeLabel;
        private Label vehicleUserIDLabel;
        private Label vehicleIDLabel;
        private Label serviceDateLabel;
        private Label serviceLabel;
        private Label notesLabel;
        private Label costLabel;
        private Label odometerLabel;
        private Label maintenanceVehicleIDLabel;
        private Label maintenanceLabel;
        private CheckedListBox serviceCheckedListBox;
        private ListBox vehicleListBox;
        private ListBox maintenanceListBox;
    }
}
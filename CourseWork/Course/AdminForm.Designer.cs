
namespace Course
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinalCityList = new System.Windows.Forms.ListBox();
            this.StartCityList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZeroFlight = new System.Windows.Forms.Label();
            this.ZeroVoyage = new System.Windows.Forms.Label();
            this.FlightList = new System.Windows.Forms.ListBox();
            this.VoyageList = new System.Windows.Forms.ListBox();
            this.AddCityBtn = new System.Windows.Forms.Button();
            this.EditCityBtn = new System.Windows.Forms.Button();
            this.RemoveCityBtn = new System.Windows.Forms.Button();
            this.TbCityName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbVoyageName = new System.Windows.Forms.TextBox();
            this.RemoveVoyageBtn = new System.Windows.Forms.Button();
            this.EditVoyageBtn = new System.Windows.Forms.Button();
            this.AddVoyageBtn = new System.Windows.Forms.Button();
            this.StartCityBox = new System.Windows.Forms.ComboBox();
            this.FinalCityBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbFlightName = new System.Windows.Forms.TextBox();
            this.RemoveFlightBtn = new System.Windows.Forms.Button();
            this.EdtiGlightBtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbDepartureTime = new System.Windows.Forms.TextBox();
            this.TbArrivalTime = new System.Windows.Forms.TextBox();
            this.TbSeats = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.VoyageBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TbPilot = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TbVoyageCompany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "==>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "From:";
            // 
            // FinalCityList
            // 
            this.FinalCityList.FormattingEnabled = true;
            this.FinalCityList.ItemHeight = 20;
            this.FinalCityList.Location = new System.Drawing.Point(249, 52);
            this.FinalCityList.Name = "FinalCityList";
            this.FinalCityList.Size = new System.Drawing.Size(156, 184);
            this.FinalCityList.TabIndex = 8;
            this.FinalCityList.SelectedIndexChanged += new System.EventHandler(this.FinalCityList_SelectedIndexChanged);
            // 
            // StartCityList
            // 
            this.StartCityList.FormattingEnabled = true;
            this.StartCityList.ItemHeight = 20;
            this.StartCityList.Location = new System.Drawing.Point(12, 52);
            this.StartCityList.Name = "StartCityList";
            this.StartCityList.Size = new System.Drawing.Size(156, 184);
            this.StartCityList.TabIndex = 7;
            this.StartCityList.SelectedIndexChanged += new System.EventHandler(this.StartCityList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(867, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Flights:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Suitable voyages:";
            // 
            // ZeroFlight
            // 
            this.ZeroFlight.AutoSize = true;
            this.ZeroFlight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroFlight.Location = new System.Drawing.Point(903, 131);
            this.ZeroFlight.Name = "ZeroFlight";
            this.ZeroFlight.Size = new System.Drawing.Size(70, 20);
            this.ZeroFlight.TabIndex = 15;
            this.ZeroFlight.Text = "No Flight";
            // 
            // ZeroVoyage
            // 
            this.ZeroVoyage.AutoSize = true;
            this.ZeroVoyage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroVoyage.Location = new System.Drawing.Point(544, 131);
            this.ZeroVoyage.Name = "ZeroVoyage";
            this.ZeroVoyage.Size = new System.Drawing.Size(82, 20);
            this.ZeroVoyage.TabIndex = 14;
            this.ZeroVoyage.Text = "No Voyage";
            // 
            // FlightList
            // 
            this.FlightList.FormattingEnabled = true;
            this.FlightList.ItemHeight = 20;
            this.FlightList.Location = new System.Drawing.Point(867, 52);
            this.FlightList.Name = "FlightList";
            this.FlightList.Size = new System.Drawing.Size(156, 184);
            this.FlightList.TabIndex = 13;
            this.FlightList.SelectedIndexChanged += new System.EventHandler(this.FlightList_SelectedIndexChanged);
            // 
            // VoyageList
            // 
            this.VoyageList.FormattingEnabled = true;
            this.VoyageList.ItemHeight = 20;
            this.VoyageList.Location = new System.Drawing.Point(510, 52);
            this.VoyageList.Name = "VoyageList";
            this.VoyageList.Size = new System.Drawing.Size(156, 184);
            this.VoyageList.TabIndex = 12;
            this.VoyageList.SelectedIndexChanged += new System.EventHandler(this.VoyageList_SelectedIndexChanged);
            // 
            // AddCityBtn
            // 
            this.AddCityBtn.Location = new System.Drawing.Point(11, 313);
            this.AddCityBtn.Name = "AddCityBtn";
            this.AddCityBtn.Size = new System.Drawing.Size(113, 54);
            this.AddCityBtn.TabIndex = 18;
            this.AddCityBtn.Text = "Add City";
            this.AddCityBtn.UseVisualStyleBackColor = true;
            this.AddCityBtn.Click += new System.EventHandler(this.AddCityBtn_Click);
            // 
            // EditCityBtn
            // 
            this.EditCityBtn.Location = new System.Drawing.Point(130, 313);
            this.EditCityBtn.Name = "EditCityBtn";
            this.EditCityBtn.Size = new System.Drawing.Size(113, 54);
            this.EditCityBtn.TabIndex = 19;
            this.EditCityBtn.Text = "Edit City (by start)";
            this.EditCityBtn.UseVisualStyleBackColor = true;
            this.EditCityBtn.Click += new System.EventHandler(this.EditCityBtn_Click);
            // 
            // RemoveCityBtn
            // 
            this.RemoveCityBtn.Location = new System.Drawing.Point(249, 313);
            this.RemoveCityBtn.Name = "RemoveCityBtn";
            this.RemoveCityBtn.Size = new System.Drawing.Size(113, 54);
            this.RemoveCityBtn.TabIndex = 20;
            this.RemoveCityBtn.Text = "Remove City (by start)";
            this.RemoveCityBtn.UseVisualStyleBackColor = true;
            this.RemoveCityBtn.Click += new System.EventHandler(this.RemoveCityBtn_Click);
            // 
            // TbCityName
            // 
            this.TbCityName.Location = new System.Drawing.Point(130, 263);
            this.TbCityName.Name = "TbCityName";
            this.TbCityName.Size = new System.Drawing.Size(169, 27);
            this.TbCityName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(55, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(435, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name:";
            // 
            // TbVoyageName
            // 
            this.TbVoyageName.Location = new System.Drawing.Point(510, 264);
            this.TbVoyageName.Name = "TbVoyageName";
            this.TbVoyageName.Size = new System.Drawing.Size(169, 27);
            this.TbVoyageName.TabIndex = 26;
            // 
            // RemoveVoyageBtn
            // 
            this.RemoveVoyageBtn.Location = new System.Drawing.Point(629, 426);
            this.RemoveVoyageBtn.Name = "RemoveVoyageBtn";
            this.RemoveVoyageBtn.Size = new System.Drawing.Size(126, 54);
            this.RemoveVoyageBtn.TabIndex = 25;
            this.RemoveVoyageBtn.Text = "Remove Voyage";
            this.RemoveVoyageBtn.UseVisualStyleBackColor = true;
            this.RemoveVoyageBtn.Click += new System.EventHandler(this.RemoveVoyageBtn_Click);
            // 
            // EditVoyageBtn
            // 
            this.EditVoyageBtn.Location = new System.Drawing.Point(510, 426);
            this.EditVoyageBtn.Name = "EditVoyageBtn";
            this.EditVoyageBtn.Size = new System.Drawing.Size(113, 54);
            this.EditVoyageBtn.TabIndex = 24;
            this.EditVoyageBtn.Text = "Edit Voyage";
            this.EditVoyageBtn.UseVisualStyleBackColor = true;
            this.EditVoyageBtn.Click += new System.EventHandler(this.EditVoyageBtn_Click);
            // 
            // AddVoyageBtn
            // 
            this.AddVoyageBtn.Location = new System.Drawing.Point(391, 426);
            this.AddVoyageBtn.Name = "AddVoyageBtn";
            this.AddVoyageBtn.Size = new System.Drawing.Size(113, 54);
            this.AddVoyageBtn.TabIndex = 23;
            this.AddVoyageBtn.Text = "Add Voyage";
            this.AddVoyageBtn.UseVisualStyleBackColor = true;
            this.AddVoyageBtn.Click += new System.EventHandler(this.AddVoyageBtn_Click);
            // 
            // StartCityBox
            // 
            this.StartCityBox.FormattingEnabled = true;
            this.StartCityBox.Location = new System.Drawing.Point(429, 381);
            this.StartCityBox.Name = "StartCityBox";
            this.StartCityBox.Size = new System.Drawing.Size(151, 28);
            this.StartCityBox.TabIndex = 28;
            // 
            // FinalCityBox
            // 
            this.FinalCityBox.FormattingEnabled = true;
            this.FinalCityBox.Location = new System.Drawing.Point(586, 381);
            this.FinalCityBox.Name = "FinalCityBox";
            this.FinalCityBox.Size = new System.Drawing.Size(151, 28);
            this.FinalCityBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(586, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(792, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Name:";
            // 
            // TbFlightName
            // 
            this.TbFlightName.Location = new System.Drawing.Point(867, 265);
            this.TbFlightName.Name = "TbFlightName";
            this.TbFlightName.Size = new System.Drawing.Size(169, 27);
            this.TbFlightName.TabIndex = 35;
            // 
            // RemoveFlightBtn
            // 
            this.RemoveFlightBtn.Location = new System.Drawing.Point(1022, 477);
            this.RemoveFlightBtn.Name = "RemoveFlightBtn";
            this.RemoveFlightBtn.Size = new System.Drawing.Size(117, 54);
            this.RemoveFlightBtn.TabIndex = 34;
            this.RemoveFlightBtn.Text = "Remove Flight";
            this.RemoveFlightBtn.UseVisualStyleBackColor = true;
            this.RemoveFlightBtn.Click += new System.EventHandler(this.RemoveFlightBtn_Click);
            // 
            // EdtiGlightBtn
            // 
            this.EdtiGlightBtn.Location = new System.Drawing.Point(903, 477);
            this.EdtiGlightBtn.Name = "EdtiGlightBtn";
            this.EdtiGlightBtn.Size = new System.Drawing.Size(113, 54);
            this.EdtiGlightBtn.TabIndex = 33;
            this.EdtiGlightBtn.Text = "Edit Flight";
            this.EdtiGlightBtn.UseVisualStyleBackColor = true;
            this.EdtiGlightBtn.Click += new System.EventHandler(this.EditFlightBtn_Click);
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.Location = new System.Drawing.Point(784, 477);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(113, 54);
            this.AddFlightBtn.TabIndex = 32;
            this.AddFlightBtn.Text = "Add Flight (New Pilot)";
            this.AddFlightBtn.UseVisualStyleBackColor = true;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(792, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Time of departure:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(792, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Pilot:";
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(930, 301);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(176, 27);
            this.DepartureDate.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(792, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Time of arrival:";
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.Location = new System.Drawing.Point(930, 337);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(176, 27);
            this.ArrivalDate.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(792, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Seats:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(792, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Price:";
            // 
            // TbDepartureTime
            // 
            this.TbDepartureTime.Location = new System.Drawing.Point(1112, 301);
            this.TbDepartureTime.Name = "TbDepartureTime";
            this.TbDepartureTime.Size = new System.Drawing.Size(72, 27);
            this.TbDepartureTime.TabIndex = 47;
            // 
            // TbArrivalTime
            // 
            this.TbArrivalTime.Location = new System.Drawing.Point(1112, 337);
            this.TbArrivalTime.Name = "TbArrivalTime";
            this.TbArrivalTime.Size = new System.Drawing.Size(72, 27);
            this.TbArrivalTime.TabIndex = 48;
            // 
            // TbSeats
            // 
            this.TbSeats.Location = new System.Drawing.Point(867, 373);
            this.TbSeats.Name = "TbSeats";
            this.TbSeats.Size = new System.Drawing.Size(69, 27);
            this.TbSeats.TabIndex = 51;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(867, 406);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(69, 27);
            this.TbPrice.TabIndex = 52;
            // 
            // VoyageBox
            // 
            this.VoyageBox.FormattingEnabled = true;
            this.VoyageBox.Location = new System.Drawing.Point(1088, 405);
            this.VoyageBox.Name = "VoyageBox";
            this.VoyageBox.Size = new System.Drawing.Size(101, 28);
            this.VoyageBox.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1021, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Voyage:";
            // 
            // TbPilot
            // 
            this.TbPilot.Location = new System.Drawing.Point(867, 440);
            this.TbPilot.Name = "TbPilot";
            this.TbPilot.Size = new System.Drawing.Size(69, 27);
            this.TbPilot.TabIndex = 55;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(420, 308);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 20);
            this.label18.TabIndex = 57;
            this.label18.Text = "Company:";
            // 
            // TbVoyageCompany
            // 
            this.TbVoyageCompany.Location = new System.Drawing.Point(510, 305);
            this.TbVoyageCompany.Name = "TbVoyageCompany";
            this.TbVoyageCompany.Size = new System.Drawing.Size(169, 27);
            this.TbVoyageCompany.TabIndex = 58;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 546);
            this.Controls.Add(this.TbVoyageCompany);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TbPilot);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.VoyageBox);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.TbSeats);
            this.Controls.Add(this.TbArrivalTime);
            this.Controls.Add(this.TbDepartureTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ArrivalDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DepartureDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbFlightName);
            this.Controls.Add(this.RemoveFlightBtn);
            this.Controls.Add(this.EdtiGlightBtn);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FinalCityBox);
            this.Controls.Add(this.StartCityBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbVoyageName);
            this.Controls.Add(this.RemoveVoyageBtn);
            this.Controls.Add(this.EditVoyageBtn);
            this.Controls.Add(this.AddVoyageBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbCityName);
            this.Controls.Add(this.RemoveCityBtn);
            this.Controls.Add(this.EditCityBtn);
            this.Controls.Add(this.AddCityBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZeroFlight);
            this.Controls.Add(this.ZeroVoyage);
            this.Controls.Add(this.FlightList);
            this.Controls.Add(this.VoyageList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinalCityList);
            this.Controls.Add(this.StartCityList);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FinalCityList;
        private System.Windows.Forms.ListBox StartCityList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ZeroFlight;
        private System.Windows.Forms.Label ZeroVoyage;
        private System.Windows.Forms.ListBox FlightList;
        private System.Windows.Forms.ListBox VoyageList;
        private System.Windows.Forms.Button AddCityBtn;
        private System.Windows.Forms.Button EditCityBtn;
        private System.Windows.Forms.Button RemoveCityBtn;
        private System.Windows.Forms.TextBox TbCityName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbVoyageName;
        private System.Windows.Forms.Button RemoveVoyageBtn;
        private System.Windows.Forms.Button EditVoyageBtn;
        private System.Windows.Forms.Button AddVoyageBtn;
        private System.Windows.Forms.ComboBox StartCityBox;
        private System.Windows.Forms.ComboBox FinalCityBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbFlightName;
        private System.Windows.Forms.Button RemoveFlightBtn;
        private System.Windows.Forms.Button EdtiGlightBtn;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker ArrivalDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbDepartureTime;
        private System.Windows.Forms.TextBox TbArrivalTime;
        private System.Windows.Forms.TextBox TbSeats;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.ComboBox VoyageBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TbPilot;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TbVoyageCompany;
    }
}
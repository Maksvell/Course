
namespace Course
{
    partial class UserForm
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
            this.StartCityList = new System.Windows.Forms.ListBox();
            this.FinalCityList = new System.Windows.Forms.ListBox();
            this.VoyageList = new System.Windows.Forms.ListBox();
            this.FlightList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZeroVoyage = new System.Windows.Forms.Label();
            this.ZeroFlight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.DepartureTime = new System.Windows.Forms.Label();
            this.ArrivalTime = new System.Windows.Forms.Label();
            this.ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Seats = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Pilot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TbCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartCityList
            // 
            this.StartCityList.FormattingEnabled = true;
            this.StartCityList.ItemHeight = 20;
            this.StartCityList.Location = new System.Drawing.Point(55, 73);
            this.StartCityList.Name = "StartCityList";
            this.StartCityList.Size = new System.Drawing.Size(156, 184);
            this.StartCityList.TabIndex = 0;
            this.StartCityList.SelectedIndexChanged += new System.EventHandler(this.StartCityList_SelectedIndexChanged);
            // 
            // FinalCityList
            // 
            this.FinalCityList.FormattingEnabled = true;
            this.FinalCityList.ItemHeight = 20;
            this.FinalCityList.Location = new System.Drawing.Point(292, 73);
            this.FinalCityList.Name = "FinalCityList";
            this.FinalCityList.Size = new System.Drawing.Size(156, 184);
            this.FinalCityList.TabIndex = 1;
            this.FinalCityList.SelectedIndexChanged += new System.EventHandler(this.FinalCityList_SelectedIndexChanged);
            // 
            // VoyageList
            // 
            this.VoyageList.FormattingEnabled = true;
            this.VoyageList.ItemHeight = 20;
            this.VoyageList.Location = new System.Drawing.Point(55, 344);
            this.VoyageList.Name = "VoyageList";
            this.VoyageList.Size = new System.Drawing.Size(156, 184);
            this.VoyageList.TabIndex = 2;
            this.VoyageList.SelectedIndexChanged += new System.EventHandler(this.VoyageList_SelectedIndexChanged);
            // 
            // FlightList
            // 
            this.FlightList.FormattingEnabled = true;
            this.FlightList.ItemHeight = 20;
            this.FlightList.Location = new System.Drawing.Point(292, 344);
            this.FlightList.Name = "FlightList";
            this.FlightList.Size = new System.Drawing.Size(156, 184);
            this.FlightList.TabIndex = 3;
            this.FlightList.SelectedIndexChanged += new System.EventHandler(this.FlightList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "==>";
            // 
            // ZeroVoyage
            // 
            this.ZeroVoyage.AutoSize = true;
            this.ZeroVoyage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroVoyage.Location = new System.Drawing.Point(89, 423);
            this.ZeroVoyage.Name = "ZeroVoyage";
            this.ZeroVoyage.Size = new System.Drawing.Size(82, 20);
            this.ZeroVoyage.TabIndex = 7;
            this.ZeroVoyage.Text = "No Voyage";
            // 
            // ZeroFlight
            // 
            this.ZeroFlight.AutoSize = true;
            this.ZeroFlight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroFlight.Location = new System.Drawing.Point(328, 423);
            this.ZeroFlight.Name = "ZeroFlight";
            this.ZeroFlight.Size = new System.Drawing.Size(70, 20);
            this.ZeroFlight.TabIndex = 8;
            this.ZeroFlight.Text = "No Flight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suitable voyages:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Flights:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(568, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Information about flight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Time of departure:";
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(721, 199);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(176, 27);
            this.DepartureDate.TabIndex = 13;
            // 
            // DepartureTime
            // 
            this.DepartureTime.AutoSize = true;
            this.DepartureTime.Location = new System.Drawing.Point(903, 201);
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Size = new System.Drawing.Size(13, 20);
            this.DepartureTime.TabIndex = 14;
            this.DepartureTime.Text = " ";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.AutoSize = true;
            this.ArrivalTime.Location = new System.Drawing.Point(903, 237);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(13, 20);
            this.ArrivalTime.TabIndex = 17;
            this.ArrivalTime.Text = " ";
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.Location = new System.Drawing.Point(721, 235);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(176, 27);
            this.ArrivalDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Time of arrival:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Seats:";
            // 
            // Seats
            // 
            this.Seats.AutoSize = true;
            this.Seats.Location = new System.Drawing.Point(642, 272);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(17, 20);
            this.Seats.TabIndex = 19;
            this.Seats.Text = "0";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(642, 305);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(17, 20);
            this.Price.TabIndex = 21;
            this.Price.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(568, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Pilot:";
            // 
            // Pilot
            // 
            this.Pilot.AutoSize = true;
            this.Pilot.Location = new System.Drawing.Point(642, 339);
            this.Pilot.Name = "Pilot";
            this.Pilot.Size = new System.Drawing.Size(15, 20);
            this.Pilot.TabIndex = 23;
            this.Pilot.Text = "_";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(674, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 55);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buy a ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(568, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Company:";
            // 
            // TbCompany
            // 
            this.TbCompany.AutoSize = true;
            this.TbCompany.Location = new System.Drawing.Point(674, 374);
            this.TbCompany.Name = "TbCompany";
            this.TbCompany.Size = new System.Drawing.Size(15, 20);
            this.TbCompany.TabIndex = 26;
            this.TbCompany.Text = "_";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 558);
            this.Controls.Add(this.TbCompany);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pilot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ArrivalTime);
            this.Controls.Add(this.ArrivalDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DepartureTime);
            this.Controls.Add(this.DepartureDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZeroFlight);
            this.Controls.Add(this.ZeroVoyage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlightList);
            this.Controls.Add(this.VoyageList);
            this.Controls.Add(this.FinalCityList);
            this.Controls.Add(this.StartCityList);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StartCityList;
        private System.Windows.Forms.ListBox FinalCityList;
        private System.Windows.Forms.ListBox VoyageList;
        private System.Windows.Forms.ListBox FlightList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ZeroVoyage;
        private System.Windows.Forms.Label ZeroFlight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.Label DepartureTime;
        private System.Windows.Forms.Label ArrivalTime;
        private System.Windows.Forms.DateTimePicker ArrivalDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Seats;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Pilot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TbCompany;
    }
}
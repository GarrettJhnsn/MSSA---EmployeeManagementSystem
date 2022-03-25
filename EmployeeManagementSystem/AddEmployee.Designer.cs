namespace AccountManagement
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textState = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textState1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFName.Location = new System.Drawing.Point(55, 205);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(113, 26);
            this.textFName.TabIndex = 7;
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLName.Location = new System.Drawing.Point(206, 205);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(113, 26);
            this.textLName.TabIndex = 8;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPhoneNumber.Location = new System.Drawing.Point(55, 259);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(113, 26);
            this.textPhoneNumber.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(206, 259);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(113, 26);
            this.textEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(206, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(96, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // textState
            // 
            this.textState.AutoSize = true;
            this.textState.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textState.Location = new System.Drawing.Point(206, 288);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(47, 22);
            this.textState.TabIndex = 20;
            this.textState.Text = "State";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.City.Location = new System.Drawing.Point(55, 288);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(39, 22);
            this.City.TabIndex = 19;
            this.City.Text = "City";
            // 
            // textCity
            // 
            this.textCity.AccessibleName = "";
            this.textCity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCity.Location = new System.Drawing.Point(55, 313);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(113, 26);
            this.textCity.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(148, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Clear Fields";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textState1
            // 
            this.textState1.AccessibleName = "";
            this.textState1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textState1.Location = new System.Drawing.Point(206, 313);
            this.textState1.Name = "textState1";
            this.textState1.Size = new System.Drawing.Size(113, 26);
            this.textState1.TabIndex = 22;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 461);
            this.Controls.Add(this.textState1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.City);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textFName;
        private TextBox textLName;
        private TextBox textPhoneNumber;
        private TextBox textEmail;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox2;
        private Label textState;
        private Label City;
        private TextBox textCity;
        private Label label6;
        private TextBox textState1;
    }
}
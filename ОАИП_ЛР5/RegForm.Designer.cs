namespace ОАИП_ЛР5
{
    partial class RegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegSurname = new System.Windows.Forms.TextBox();
            this.RegPhone = new System.Windows.Forms.TextBox();
            this.RegBirth = new System.Windows.Forms.DateTimePicker();
            this.RegEntrance = new System.Windows.Forms.DateTimePicker();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dfdf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vdvd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dfdfds = new System.Windows.Forms.Label();
            this.dfdfd = new System.Windows.Forms.Label();
            this.gfgfd = new System.Windows.Forms.Label();
            this.xvxcv = new System.Windows.Forms.Label();
            this.RegFaculty = new System.Windows.Forms.ComboBox();
            this.RegCourse = new System.Windows.Forms.ComboBox();
            this.RegGroup = new System.Windows.Forms.ComboBox();
            this.RegLogin = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlreadyReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(66, 143);
            this.RegName.MaxLength = 20;
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(144, 22);
            this.RegName.TabIndex = 1;
            // 
            // RegSurname
            // 
            this.RegSurname.Location = new System.Drawing.Point(243, 143);
            this.RegSurname.MaxLength = 20;
            this.RegSurname.Name = "RegSurname";
            this.RegSurname.Size = new System.Drawing.Size(144, 22);
            this.RegSurname.TabIndex = 2;
            // 
            // RegPhone
            // 
            this.RegPhone.Location = new System.Drawing.Point(243, 219);
            this.RegPhone.MaxLength = 12;
            this.RegPhone.Name = "RegPhone";
            this.RegPhone.Size = new System.Drawing.Size(144, 22);
            this.RegPhone.TabIndex = 3;
            this.RegPhone.Text = "+7";
            // 
            // RegBirth
            // 
            this.RegBirth.Location = new System.Drawing.Point(66, 219);
            this.RegBirth.MaxDate = new System.DateTime(2025, 4, 29, 22, 10, 29, 0);
            this.RegBirth.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.RegBirth.Name = "RegBirth";
            this.RegBirth.Size = new System.Drawing.Size(144, 22);
            this.RegBirth.TabIndex = 4;
            this.RegBirth.Value = new System.DateTime(2025, 4, 29, 0, 0, 0, 0);
            // 
            // RegEntrance
            // 
            this.RegEntrance.CustomFormat = "yyyy";
            this.RegEntrance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegEntrance.Location = new System.Drawing.Point(243, 372);
            this.RegEntrance.MaxDate = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            this.RegEntrance.MinDate = new System.DateTime(1950, 9, 1, 0, 0, 0, 0);
            this.RegEntrance.Name = "RegEntrance";
            this.RegEntrance.ShowUpDown = true;
            this.RegEntrance.Size = new System.Drawing.Size(144, 22);
            this.RegEntrance.TabIndex = 8;
            this.RegEntrance.Value = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(443, 219);
            this.RegEmail.MaxLength = 50;
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(331, 22);
            this.RegEmail.TabIndex = 9;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.LightGreen;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(443, 291);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(331, 51);
            this.buttonReg.TabIndex = 10;
            this.buttonReg.Text = "Зарегаться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // dfdf
            // 
            this.dfdf.AutoSize = true;
            this.dfdf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dfdf.Location = new System.Drawing.Point(239, 179);
            this.dfdf.Name = "dfdf";
            this.dfdf.Size = new System.Drawing.Size(92, 24);
            this.dfdf.TabIndex = 12;
            this.dfdf.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(239, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Фамилия";
            // 
            // vdvd
            // 
            this.vdvd.AutoSize = true;
            this.vdvd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vdvd.Location = new System.Drawing.Point(62, 179);
            this.vdvd.Name = "vdvd";
            this.vdvd.Size = new System.Drawing.Size(115, 24);
            this.vdvd.TabIndex = 14;
            this.vdvd.Text = "Дата рожд.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(62, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Группа";
            // 
            // dfdfds
            // 
            this.dfdfds.AutoSize = true;
            this.dfdfds.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dfdfds.Location = new System.Drawing.Point(62, 260);
            this.dfdfds.Name = "dfdfds";
            this.dfdfds.Size = new System.Drawing.Size(106, 24);
            this.dfdfds.TabIndex = 16;
            this.dfdfds.Text = "Факультет";
            // 
            // dfdfd
            // 
            this.dfdfd.AutoSize = true;
            this.dfdfd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dfdfd.Location = new System.Drawing.Point(239, 260);
            this.dfdfd.Name = "dfdfd";
            this.dfdfd.Size = new System.Drawing.Size(52, 24);
            this.dfdfd.TabIndex = 17;
            this.dfdfd.Text = "Курс";
            // 
            // gfgfd
            // 
            this.gfgfd.AutoSize = true;
            this.gfgfd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gfgfd.Location = new System.Drawing.Point(239, 332);
            this.gfgfd.Name = "gfgfd";
            this.gfgfd.Size = new System.Drawing.Size(129, 24);
            this.gfgfd.TabIndex = 18;
            this.gfgfd.Text = "Поступление";
            // 
            // xvxcv
            // 
            this.xvxcv.AutoSize = true;
            this.xvxcv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xvxcv.Location = new System.Drawing.Point(439, 183);
            this.xvxcv.Name = "xvxcv";
            this.xvxcv.Size = new System.Drawing.Size(66, 24);
            this.xvxcv.TabIndex = 19;
            this.xvxcv.Text = "Почта";
            // 
            // RegFaculty
            // 
            this.RegFaculty.FormattingEnabled = true;
            this.RegFaculty.Location = new System.Drawing.Point(66, 296);
            this.RegFaculty.Name = "RegFaculty";
            this.RegFaculty.Size = new System.Drawing.Size(144, 24);
            this.RegFaculty.TabIndex = 20;
            this.RegFaculty.SelectedIndexChanged += new System.EventHandler(this.RegFaculty_SelectedIndexChanged);
            // 
            // RegCourse
            // 
            this.RegCourse.FormattingEnabled = true;
            this.RegCourse.Location = new System.Drawing.Point(243, 296);
            this.RegCourse.Name = "RegCourse";
            this.RegCourse.Size = new System.Drawing.Size(144, 24);
            this.RegCourse.TabIndex = 21;
            this.RegCourse.SelectedIndexChanged += new System.EventHandler(this.RegCourse_SelectedIndexChanged);
            // 
            // RegGroup
            // 
            this.RegGroup.FormattingEnabled = true;
            this.RegGroup.Location = new System.Drawing.Point(66, 370);
            this.RegGroup.Name = "RegGroup";
            this.RegGroup.Size = new System.Drawing.Size(144, 24);
            this.RegGroup.TabIndex = 22;
            // 
            // RegLogin
            // 
            this.RegLogin.Location = new System.Drawing.Point(443, 143);
            this.RegLogin.MaxLength = 20;
            this.RegLogin.Name = "RegLogin";
            this.RegLogin.Size = new System.Drawing.Size(144, 22);
            this.RegLogin.TabIndex = 23;
            // 
            // RegPassword
            // 
            this.RegPassword.Location = new System.Drawing.Point(630, 143);
            this.RegPassword.MaxLength = 35;
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(144, 22);
            this.RegPassword.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(439, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(626, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Пароль";
            // 
            // AlreadyReg
            // 
            this.AlreadyReg.AutoSize = true;
            this.AlreadyReg.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlreadyReg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AlreadyReg.Location = new System.Drawing.Point(543, 372);
            this.AlreadyReg.Name = "AlreadyReg";
            this.AlreadyReg.Size = new System.Drawing.Size(133, 24);
            this.AlreadyReg.TabIndex = 33;
            this.AlreadyReg.Text = "Уже зареганы?";
            this.AlreadyReg.Click += new System.EventHandler(this.AlreadyReg_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.AlreadyReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegLogin);
            this.Controls.Add(this.RegGroup);
            this.Controls.Add(this.RegCourse);
            this.Controls.Add(this.RegFaculty);
            this.Controls.Add(this.xvxcv);
            this.Controls.Add(this.gfgfd);
            this.Controls.Add(this.dfdfd);
            this.Controls.Add(this.dfdfds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vdvd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dfdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.RegEntrance);
            this.Controls.Add(this.RegBirth);
            this.Controls.Add(this.RegPhone);
            this.Controls.Add(this.RegSurname);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.label1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegSurname;
        private System.Windows.Forms.TextBox RegPhone;
        private System.Windows.Forms.DateTimePicker RegBirth;
        private System.Windows.Forms.DateTimePicker RegEntrance;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dfdf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vdvd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dfdfds;
        private System.Windows.Forms.Label dfdfd;
        private System.Windows.Forms.Label gfgfd;
        private System.Windows.Forms.Label xvxcv;
        private System.Windows.Forms.ComboBox RegFaculty;
        private System.Windows.Forms.ComboBox RegCourse;
        private System.Windows.Forms.ComboBox RegGroup;
        private System.Windows.Forms.TextBox RegLogin;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AlreadyReg;
    }
}
namespace ОАИП_ЛР5
{
    partial class AuthForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthPassword = new System.Windows.Forms.TextBox();
            this.AuthLogin = new System.Windows.Forms.TextBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLostPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(165, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(165, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Логин";
            // 
            // AuthPassword
            // 
            this.AuthPassword.Location = new System.Drawing.Point(120, 224);
            this.AuthPassword.MaxLength = 35;
            this.AuthPassword.Name = "AuthPassword";
            this.AuthPassword.Size = new System.Drawing.Size(169, 22);
            this.AuthPassword.TabIndex = 28;
            // 
            // AuthLogin
            // 
            this.AuthLogin.Location = new System.Drawing.Point(120, 153);
            this.AuthLogin.MaxLength = 20;
            this.AuthLogin.Name = "AuthLogin";
            this.AuthLogin.Size = new System.Drawing.Size(169, 22);
            this.AuthLogin.TabIndex = 27;
            // 
            // buttonAuth
            // 
            this.buttonAuth.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.Location = new System.Drawing.Point(147, 264);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(119, 41);
            this.buttonAuth.TabIndex = 31;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = false;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(136, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Еще не зареганы?";
            this.label2.Click += new System.EventHandler(this.labelDontReg_Click);
            // 
            // labelLostPass
            // 
            this.labelLostPass.AutoSize = true;
            this.labelLostPass.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLostPass.ForeColor = System.Drawing.Color.Green;
            this.labelLostPass.Location = new System.Drawing.Point(93, 326);
            this.labelLostPass.Name = "labelLostPass";
            this.labelLostPass.Size = new System.Drawing.Size(235, 24);
            this.labelLostPass.TabIndex = 35;
            this.labelLostPass.Text = "Забыли логин или пароль?";
            this.labelLostPass.Click += new System.EventHandler(this.labelLostPass_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(415, 439);
            this.Controls.Add(this.labelLostPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthPassword);
            this.Controls.Add(this.AuthLogin);
            this.Controls.Add(this.label1);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AuthPassword;
        private System.Windows.Forms.TextBox AuthLogin;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLostPass;
    }
}
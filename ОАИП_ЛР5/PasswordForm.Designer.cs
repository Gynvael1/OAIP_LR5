namespace ОАИП_ЛР5
{
    partial class PasswordForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.xvxcv = new System.Windows.Forms.Label();
            this.PassEmail = new System.Windows.Forms.TextBox();
            this.buttonNewPass = new System.Windows.Forms.Button();
            this.PassRemember = new System.Windows.Forms.Label();
            this.timerPass = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Востановление доступа";
            // 
            // xvxcv
            // 
            this.xvxcv.AutoSize = true;
            this.xvxcv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xvxcv.Location = new System.Drawing.Point(90, 103);
            this.xvxcv.Name = "xvxcv";
            this.xvxcv.Size = new System.Drawing.Size(66, 24);
            this.xvxcv.TabIndex = 21;
            this.xvxcv.Text = "Почта";
            // 
            // PassEmail
            // 
            this.PassEmail.Location = new System.Drawing.Point(94, 139);
            this.PassEmail.MaxLength = 50;
            this.PassEmail.Name = "PassEmail";
            this.PassEmail.Size = new System.Drawing.Size(331, 22);
            this.PassEmail.TabIndex = 20;
            // 
            // buttonNewPass
            // 
            this.buttonNewPass.BackColor = System.Drawing.Color.LightGreen;
            this.buttonNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewPass.Location = new System.Drawing.Point(124, 214);
            this.buttonNewPass.Name = "buttonNewPass";
            this.buttonNewPass.Size = new System.Drawing.Size(278, 51);
            this.buttonNewPass.TabIndex = 22;
            this.buttonNewPass.Text = "Отправить новый пароль";
            this.buttonNewPass.UseVisualStyleBackColor = false;
            this.buttonNewPass.Click += new System.EventHandler(this.buttonNewPass_Click);
            // 
            // PassRemember
            // 
            this.PassRemember.AutoSize = true;
            this.PassRemember.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassRemember.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PassRemember.Location = new System.Drawing.Point(231, 299);
            this.PassRemember.Name = "PassRemember";
            this.PassRemember.Size = new System.Drawing.Size(58, 24);
            this.PassRemember.TabIndex = 34;
            this.PassRemember.Text = "Назад";
            this.PassRemember.Click += new System.EventHandler(this.PassRemember_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(539, 361);
            this.Controls.Add(this.PassRemember);
            this.Controls.Add(this.buttonNewPass);
            this.Controls.Add(this.xvxcv);
            this.Controls.Add(this.PassEmail);
            this.Controls.Add(this.label1);
            this.Name = "PasswordForm";
            this.Text = "yt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xvxcv;
        private System.Windows.Forms.TextBox PassEmail;
        private System.Windows.Forms.Button buttonNewPass;
        private System.Windows.Forms.Label PassRemember;
        private System.Windows.Forms.Timer timerPass;
    }
}
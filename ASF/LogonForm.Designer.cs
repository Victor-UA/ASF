namespace ASF
{
    partial class LogonForm
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
            this.b_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Enter
            // 
            this.b_Enter.Location = new System.Drawing.Point(58, 110);
            this.b_Enter.Name = "b_Enter";
            this.b_Enter.Size = new System.Drawing.Size(75, 23);
            this.b_Enter.TabIndex = 2;
            this.b_Enter.Text = "Вхід";
            this.b_Enter.UseVisualStyleBackColor = true;
            this.b_Enter.Click += new System.EventHandler(this.b_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я користувача";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // tB_Login
            // 
            this.tB_Login.Location = new System.Drawing.Point(128, 46);
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(150, 20);
            this.tB_Login.TabIndex = 0;
            this.tB_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Login_KeyPress);
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(128, 68);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(150, 20);
            this.tB_Password.TabIndex = 1;
            this.tB_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Password_KeyPress);
            // 
            // b_Cancel
            // 
            this.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Cancel.Location = new System.Drawing.Point(184, 110);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 3;
            this.b_Cancel.Text = "Відміна";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вітаємо у базі даних АСФ";
            // 
            // LogonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_Cancel;
            this.ClientSize = new System.Drawing.Size(313, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація користувача";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogonForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Login;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Label label3;
    }
}
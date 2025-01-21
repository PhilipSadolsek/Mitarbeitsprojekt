namespace Mitarbeitsprojekt
{
    partial class Login
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
            labelServer = new Label();
            LabelSSPI = new Label();
            LabelUser = new Label();
            LabelPassword = new Label();
            TextBoxServer = new TextBox();
            CheckBoxSSPI = new CheckBox();
            TextBoxUser = new TextBox();
            TextBoxPassword = new TextBox();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(12, 36);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(42, 15);
            labelServer.TabIndex = 0;
            labelServer.Text = "Server:";
            // 
            // LabelSSPI
            // 
            LabelSSPI.AutoSize = true;
            LabelSSPI.Location = new Point(12, 65);
            LabelSSPI.Name = "LabelSSPI";
            LabelSSPI.Size = new Size(29, 15);
            LabelSSPI.TabIndex = 1;
            LabelSSPI.Text = "SSPI";
            // 
            // LabelUser
            // 
            LabelUser.AutoSize = true;
            LabelUser.Location = new Point(12, 94);
            LabelUser.Name = "LabelUser";
            LabelUser.Size = new Size(86, 15);
            LabelUser.TabIndex = 2;
            LabelUser.Text = "Benutzername:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(12, 126);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(57, 15);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Passwort:";
            // 
            // TextBoxServer
            // 
            TextBoxServer.Location = new Point(301, 36);
            TextBoxServer.Name = "TextBoxServer";
            TextBoxServer.Size = new Size(161, 23);
            TextBoxServer.TabIndex = 4;
            TextBoxServer.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // CheckBoxSSPI
            // 
            CheckBoxSSPI.AutoSize = true;
            CheckBoxSSPI.Location = new Point(353, 66);
            CheckBoxSSPI.Name = "CheckBoxSSPI";
            CheckBoxSSPI.Size = new Size(15, 14);
            CheckBoxSSPI.TabIndex = 5;
            CheckBoxSSPI.UseVisualStyleBackColor = true;
            // 
            // TextBoxUser
            // 
            TextBoxUser.Location = new Point(301, 86);
            TextBoxUser.Name = "TextBoxUser";
            TextBoxUser.Size = new Size(161, 23);
            TextBoxUser.TabIndex = 6;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(301, 123);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(161, 23);
            TextBoxPassword.TabIndex = 7;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(176, 179);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(86, 27);
            ButtonLogin.TabIndex = 8;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 240);
            Controls.Add(ButtonLogin);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUser);
            Controls.Add(CheckBoxSSPI);
            Controls.Add(TextBoxServer);
            Controls.Add(LabelPassword);
            Controls.Add(LabelUser);
            Controls.Add(LabelSSPI);
            Controls.Add(labelServer);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelServer;
        private Label LabelSSPI;
        private Label LabelUser;
        private Label LabelPassword;
        private TextBox TextBoxServer;
        private CheckBox CheckBoxSSPI;
        private TextBox TextBoxUser;
        private TextBox TextBoxPassword;
        private Button ButtonLogin;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeitsprojekt
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LabelUser_Click(object sender, EventArgs e)
        {

        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonSSPI_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void CheckBoxSSPI_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSSPI.Checked == true)
            {
                TextBoxPassword.Visible = false;
                TextBoxUser.Visible = false;


                LabelPassword.Visible = false;
                LabelUser.Visible = false;
            }
            else
            {
                TextBoxPassword.Visible = true;
                TextBoxUser.Visible = true;


                LabelPassword.Visible = true;
                LabelUser.Visible = true;
            }

        }

        private string _server, _SSPI, _user, _password;

        public string server
        {
            get
            {
                return _server;
            }

            set
            {
                _server = value;
            }
        }

        public string SSPI
        {
            get
            {
                return _SSPI;
            }

            set
            {
                if (CheckBoxSSPI.Checked == true)
                {
                    _SSPI = "true";
                }

                else
                {
                    _SSPI = "false";
                }
            }
        }

        public string user
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }



        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            string SSPI;
            if (CheckBoxSSPI.Checked == true)
            {
                SSPI = "true";
            }
            else
            {
                {
                    SSPI = "false";
                }
            }


            sqlManagement sqlManagement = new sqlManagement();
            sqlManagement.SQLConn(TextBoxServer.Text, TextBoxServer.Text, TextBoxUser.Text, SSPI);

            this.Hide();

            DatabaseForm databaseForm = new DatabaseForm();
            databaseForm.ShowDialog();
        }
    }
}

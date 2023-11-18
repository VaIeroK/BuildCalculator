using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using BuildCalculator.Classes;
using BuildCalculator.Forms;
using Newtonsoft.Json.Linq;

namespace BuildCalculator.Forms
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();

            Size = new System.Drawing.Size(LoginGroupBox.Size.Width + 26, LoginGroupBox.Size.Height + 48);
            LoginGroupBox.Location = new System.Drawing.Point(5, 5);
            RegisterGroupBox.Location = new System.Drawing.Point(5, 5);
            AuthorizeLink_LinkClicked(null, null);
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGroupBox.Visible = false;
            RegisterGroupBox.Visible = true;
        }

        private void AuthorizeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGroupBox.Visible = true;
            RegisterGroupBox.Visible = false;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !(sender as CheckBox).Checked;
        }

        private void RegisterShowPasswordLabel_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPasswordTextBox.UseSystemPasswordChar = !(sender as CheckBox).Checked;
        }

        private void AuthorizeButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                EnterLoginLabel.Visible = true;
                LoginTextBox.ReadOnly = true;
                EnterLoginTimer.Start();
                return;
            }

            if (PasswordTextBox.Text == "")
            {
                EnterPasswordLabel.Visible = true;
                PasswordTextBox.ReadOnly = true;
                EnterPasswordTimer.Start();
                return;
            }

            JObject jsonObject = new JObject(
                new JProperty("username", LoginTextBox.Text),
                new JProperty("password", PasswordTextBox.Text)
            );

            HttpStatusCode Status;
            var Response = Net.GetRequest("api/login", out Status, jsonObject);

            if (Status == HttpStatusCode.OK)
            {
                MessageBox.Show(Response.ToString());
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (RegisterLoginTextBox.Text == "")
            {
                EnterRegisterLoginLabel.Visible = true;
                RegisterLoginTextBox.ReadOnly = true;
                EnterRegisterLoginTimer.Start();
                return;
            }

            if (RegisterPasswordTextBox.Text == "")
            {
                EnterRegisterPasswordLabel.Visible = true;
                RegisterPasswordTextBox.ReadOnly = true;
                EnterRegisterPasswordTimer.Start();
                return;
            }

            if (RegisterRewritePasswordTextBox.Text == "")
            {
                EnterRegisterRewritePasswordLabel.Visible = true;
                RegisterRewritePasswordTextBox.ReadOnly = true;
                EnterRegisterRewritePasswordTimer.Start();
                return;
            }

            JObject jsonObject = new JObject(
                new JProperty("username", LoginTextBox.Text),
                new JProperty("password", PasswordTextBox.Text),
                new JProperty("name", PasswordTextBox.Text),
                new JProperty("lastname", PasswordTextBox.Text)
            );

            HttpStatusCode Status;
            var Response = Net.PostRequest("api/login", out Status, jsonObject);
        }

        private void EnterLoginTimer_Tick(object sender, EventArgs e)
        {
            EnterLoginLabel.Visible = false;
            LoginTextBox.ReadOnly = false;
        }

        private void EnterPasswordTimer_Tick(object sender, EventArgs e)
        {
            EnterPasswordLabel.Visible = false;
            PasswordTextBox.ReadOnly = false;
        }

        private void EnterRegisterLoginTimer_Tick(object sender, EventArgs e)
        {
            EnterRegisterLoginLabel.Visible = false;
            RegisterLoginTextBox.ReadOnly = false;
        }

        private void EnterRegisterPasswordTimer_Tick(object sender, EventArgs e)
        {
            EnterRegisterPasswordLabel.Visible = false;
            RegisterPasswordTextBox.ReadOnly = false;
        }

        private void EnterRegisterRewritePasswordTimer_Tick(object sender, EventArgs e)
        {
            EnterRegisterRewritePasswordLabel.Visible = false;
            RegisterRewritePasswordTextBox.ReadOnly = false;
        }
    }
}

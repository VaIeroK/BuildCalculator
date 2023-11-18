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
using BuildCalculator.Properties;
using Newtonsoft.Json.Linq;

namespace BuildCalculator.Forms
{
    public partial class AuthorizeForm : Form
    {
        public string Token = null;
        public string UserName = null;
        public string UserLastName = null;
        public string UserLogin = null;
        public string UserPassword = null;
        public bool Valid = false;
        private IntPtr hIcon;

        private class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            public static extern bool DestroyIcon(IntPtr handle);
        }

        public AuthorizeForm()
        {
            InitializeComponent();

            Icon = ConvertBitmapToIcon(Resources.icon_user);

            LoginGroupBox.Location = new System.Drawing.Point(5, 5);
            RegisterGroupBox.Location = new System.Drawing.Point(5, 5);
            AuthorizeLink_LinkClicked(null, null);
        }

        Icon ConvertBitmapToIcon(Bitmap bitmap)
        {
            hIcon = bitmap.GetHicon();
            return Icon.FromHandle(hIcon);
        }

        public void DestroyIcon()
        {
            NativeMethods.DestroyIcon(hIcon);
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGroupBox.Visible = false;
            RegisterGroupBox.Visible = true;
            Size = new System.Drawing.Size(RegisterGroupBox.Size.Width + 26, RegisterGroupBox.Size.Height + 48);
            Text = "Регистрация";
        }

        private void AuthorizeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGroupBox.Visible = true;
            RegisterGroupBox.Visible = false;
            Size = new System.Drawing.Size(LoginGroupBox.Size.Width + 26, LoginGroupBox.Size.Height + 48);
            Text = "Авторизация";
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !(sender as CheckBox).Checked;
        }

        private void RegisterShowPasswordLabel_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPasswordTextBox.UseSystemPasswordChar = !(sender as CheckBox).Checked;
            RegisterRewritePasswordTextBox.UseSystemPasswordChar = !(sender as CheckBox).Checked;
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

            switch (Status)
            {
                case HttpStatusCode.OK:
                    if (Response["token"] != null)
                    {
                        Token = Response["token"].ToString();

                        if (Response["user"] != null)
                        {
                            JObject UserData = Response["user"] as JObject;
                            if (UserData["name"] != null && UserData["lastname"] != null)
                            {
                                UserName = UserData["name"].ToString();
                                UserLastName = UserData["lastname"].ToString();
                                UserLogin = UserData["login"].ToString();
                                UserPassword = UserData["password"].ToString();
                            }
                            else
                                MessageBox.Show($"Ошибка сервера. Невозможно получить имя пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show($"Ошибка сервера. Невозможно получить пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Valid = true;
                        Close();
                    }
                    else
                        MessageBox.Show($"Невозможно войти в аккаунт! Отсутствует токен пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case HttpStatusCode.Unauthorized:
                    AutoClosingMessageBox.Show("Неверный логин или пароль!", "", 2000, MessageBoxIcon.Error);
                    break;
                case HttpStatusCode.InternalServerError:
                    MessageBox.Show($"Неудается связаться с сервером.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show($"Ошибка {Status}. Невозможно войти в аккаунт!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
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

            if (RegisterNameTextBox.Text == "")
            {
                EnterRegisterNameLabel.Text = "Заполните имя";
                EnterRegisterNameLabel.Visible = true;
                RegisterNameTextBox.ReadOnly = true;
                EnterRegisterNameTimer.Start();
                return;
            }

            if (!IsOnlyLetters(RegisterNameTextBox.Text))
            {
                EnterRegisterNameLabel.Text = "Имя не должно состоять из символов";
                EnterRegisterNameLabel.Visible = true;
                RegisterNameTextBox.ReadOnly = true;
                EnterRegisterNameTimer.Start();
                return;
            }

            if (RegisterLastNameTextBox.Text == "")
            {
                EnterRegisterLastNameLabel.Text = "Заполните фамилию";
                EnterRegisterLastNameLabel.Visible = true;
                RegisterLastNameTextBox.ReadOnly = true;
                EnterRegisterLastNameTimer.Start();
                return;
            }

            if (!IsOnlyLetters(RegisterLastNameTextBox.Text))
            {
                EnterRegisterLastNameLabel.Text = "Фамилия не должна состоять из символов";
                EnterRegisterLastNameLabel.Visible = true;
                RegisterLastNameTextBox.ReadOnly = true;
                EnterRegisterLastNameTimer.Start();
                return;
            }

            if (RegisterPasswordTextBox.Text == "")
            {
                EnterRegisterPasswordLabel.Text = "Заполните пароль";
                EnterRegisterPasswordLabel.Visible = true;
                RegisterPasswordTextBox.ReadOnly = true;
                EnterRegisterPasswordTimer.Start();
                return;
            }

            if (RegisterRewritePasswordTextBox.Text == "")
            {
                EnterRegisterRewritePasswordLabel.Text = "Повторите пароль";
                EnterRegisterRewritePasswordLabel.Visible = true;
                RegisterRewritePasswordTextBox.ReadOnly = true;
                EnterRegisterRewritePasswordTimer.Start();
                return;
            }

            if (RegisterPasswordTextBox.Text != RegisterRewritePasswordTextBox.Text)
            {
                EnterRegisterPasswordLabel.Text = "Пароли не совпадают";
                EnterRegisterRewritePasswordLabel.Text = "Пароли не совпадают";
                EnterRegisterPasswordLabel.Visible = true;
                RegisterPasswordTextBox.ReadOnly = true;
                EnterRegisterRewritePasswordLabel.Visible = true;
                RegisterRewritePasswordTextBox.ReadOnly = true;
                BadPasswordsTimer.Start();
                return;
            }

            JObject jsonObject = new JObject(
                new JProperty("username", RegisterLoginTextBox.Text),
                new JProperty("password", RegisterPasswordTextBox.Text),
                new JProperty("name", RegisterNameTextBox.Text),
                new JProperty("lastname", RegisterLastNameTextBox.Text)
            );

            HttpStatusCode Status;
            var Response = Net.PostRequest("api/register", out Status, jsonObject);

            switch (Status)
            {
                case HttpStatusCode.Created:
                    if (Response["token"] != null)
                    {
                        Token = Response["token"].ToString();

                        if (Response["user"] != null)
                        {
                            JObject UserData = Response["user"] as JObject;
                            if (UserData["name"] != null && UserData["lastname"] != null)
                            {
                                UserName = UserData["name"].ToString();
                                UserLastName = UserData["lastname"].ToString();
                                UserLogin = UserData["login"].ToString();
                                UserPassword = UserData["password"].ToString();
                            }
                            else
                                MessageBox.Show($"Ошибка сервера. Невозможно получить имя пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show($"Ошибка сервера. Невозможно получить пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Valid = true;
                        Close();
                    }
                    else
                        MessageBox.Show($"Невозможно зарегистрироваться! Отсутствует токен пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case HttpStatusCode.BadRequest:
                    AutoClosingMessageBox.Show("Пользователь с таким логином уже существует!", "", 2000, MessageBoxIcon.Error);
                    break;
                case HttpStatusCode.InternalServerError:
                    MessageBox.Show($"Неудается связаться с сервером.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show($"Ошибка {Status}. Невозможно войти в аккаунт!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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

        private void EnterRegisterNameTimer_Tick(object sender, EventArgs e)
        {
            EnterRegisterNameLabel.Visible = false;
            RegisterNameTextBox.ReadOnly = false;
        }

        private void EnterRegisterLastNameTimer_Tick(object sender, EventArgs e)
        {
            EnterRegisterLastNameLabel.Visible = false;
            RegisterLastNameTextBox.ReadOnly = false;
        }

        static bool IsOnlyLetters(string input)
        {
            return input.All(char.IsLetter);
        }

        private void BadPasswordsTimer_Tick(object sender, EventArgs e)
        {
            EnterRegisterPasswordTimer_Tick(sender, e);
            EnterRegisterRewritePasswordTimer_Tick(sender, e);
        }
    }
}

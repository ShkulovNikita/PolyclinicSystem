﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyclinicSystem.Forms;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace PolyclinicSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Logger.ActivateLogger();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection db = new SQLiteConnection("Polyclinic.db"))
                {
                    
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        //нажатие на кнопку входа в профиль
        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = Authorization.SignIn(loginTextBox.Text, passwordTextBox.Text);
                if (user != null)
                {
                    loginTextBox.Text = "Вход выполнен: " + user.Name;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        //нажатие на кнопку регистрации
        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.FormClosed += SignUpForm_FormClosed;
                signUpForm.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }
        }

        //восстановление пароля
        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            try
            {
                ForgotPasswordForm form = new ForgotPasswordForm();
                form.FormClosed += ForgotPasswordForm_FormClosed;
                form.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }
        }

        //отреагировать на закрытие формы смены пароля
        private void ForgotPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        //отреагировать на закрытие формы регистрации
        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
    }
}
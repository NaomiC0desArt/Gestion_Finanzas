using FinalProject.Context;
using FinalProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms.Auth
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;

            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("El correo electronico es obligatorio");
                return;

            }

            if (!AuthHelpers.IsEmailValid(email))
            {
                MessageBox.Show("El correo no tiene un formato permitido");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("La contraseña es obligatoria");
                return;
            }

            using var db = new AppDbContext();

            var userWithSameEmail = db.Users.FirstOrDefault(x  => x.Email == email.ToLower());

            if (userWithSameEmail != null)
            {
                MessageBox.Show($"Correo ya existente en el sistema");
                return;
            }

            var passwordHashed = AuthHelpers.HashPassword(password);
            db.Users.Add(new Models.User { Email = email.ToLower(), FullName = name, Password = passwordHashed });
            db.SaveChanges();

            var login = new Login();
            login.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Close();
        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}

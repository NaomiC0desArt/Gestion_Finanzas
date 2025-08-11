using FinalProject.Context;
using FinalProject.Helpers;
using FinalProject.Models;
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
	public partial class Login : Form
	{
		public Login()
		{

			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			this.KeyPreview = true;
			this.Text = "Login page";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Application.Exit();
			}
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			var register = new Register();
			register.Show();
			this.Hide();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string password = txtPassword.Text;

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
			var user = db.Users.FirstOrDefault(x => x.Email == email.ToLower());

			if (user == null)
			{
				MessageBox.Show($"Correo o contraseña erróneos");
				return;
			}

			var isValid = AuthHelpers.VerifyPassword(password, user.Password);

			if (!isValid)
			{
				MessageBox.Show($"Correo o contraseña erróneos");
				return;

			}

			var mainForm = new Main();
			mainForm.Show();
			this.Hide();
		}

	}
}

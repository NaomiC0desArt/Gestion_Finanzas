using FinalProject.Forms.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			guna2Button2.Click += guna2Button2_Click;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			//var formCat = new FormCategories();
			//formCat.ShowDialog();
			AbrirFormularioEnPanel(new FinalProject.Forms.Categoria.FormCategories());
		}

		private void AbrirFormularioEnPanel(Form formularioHijo)
		{
			panelContenedor.Controls.Clear();

			// Configurar el formulario hijo para que no sea ventana independiente
			formularioHijo.TopLevel = false;
			formularioHijo.FormBorderStyle = FormBorderStyle.None;
			formularioHijo.Dock = DockStyle.Fill;

			panelContenedor.Controls.Add(formularioHijo);
			formularioHijo.Show();
		}
	}
}

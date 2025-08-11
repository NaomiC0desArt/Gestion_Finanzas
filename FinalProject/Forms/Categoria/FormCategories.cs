using FinalProject.Context;
using FinalProject.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms.Categoria
{
	public partial class FormCategories : Form
	{
		private readonly AppDbContext _context;

		public FormCategories()
		{
			InitializeComponent();
			nupdownLimiteCat.DecimalPlaces = 2; 
			nupdownLimiteCat.ThousandsSeparator = true;

			_context = new AppDbContext();

			CargarTipos();
			CargarCategorias();

			btnAgregar.Click += BtnAgregar_Click;
			btnEditar.Click += BtnEditar_Click;
			btnEliminar.Click += BtnEliminar_Click;
			btnLimpiar.Click += BtnLimpiar_Click;
		}

		private void CargarTipos()
		{
			cbTipoCat.DataSource = Enum.GetValues(typeof(CategoryType));
		}

		private void CargarCategorias()
		{
			dgvListaCat.DataSource = _context.Categories
											 .Select(c => new
											 {
												 c.Id,
												 c.Name,
												 c.Type,
												 c.Limit
											 })
											 .ToList();
		}

		// 🟢 Validaciones simples
		private bool ValidarFormulario()
		{
			if (string.IsNullOrWhiteSpace(txtNombreCat.Text))
			{
				MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (cbTipoCat.SelectedIndex < 0)
			{
				MessageBox.Show("Debe seleccionar un tipo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (nupdownLimiteCat.Value < 0)
			{
				MessageBox.Show("El límite no puede ser negativo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		// 🟢 Agregar categoría
		private void BtnAgregar_Click(object? sender, EventArgs e)
		{
			if (!ValidarFormulario()) return;

			var nuevaCategoria = new Category
			{
				Name = txtNombreCat.Text.Trim(),
				Type = (CategoryType)cbTipoCat.SelectedItem,
				Limit = nupdownLimiteCat.Value
			};

			_context.Categories.Add(nuevaCategoria);
			_context.SaveChanges();

			CargarCategorias();
			LimpiarFormulario();
		}

		// 🟢 Editar categoría
		private void BtnEditar_Click(object? sender, EventArgs e)
		{
			if (dgvListaCat.CurrentRow == null)
			{
				MessageBox.Show("Seleccione una categoría", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (!ValidarFormulario()) return;

			int id = (int)dgvListaCat.CurrentRow.Cells["Id"].Value;
			var categoria = _context.Categories.Find(id);

			if (categoria != null)
			{
				categoria.Name = txtNombreCat.Text.Trim();
				categoria.Type = (CategoryType)cbTipoCat.SelectedItem;
				categoria.Limit = nupdownLimiteCat.Value;

				_context.SaveChanges();
				CargarCategorias();
				LimpiarFormulario();
			}
		}

		// 🟢 Eliminar categoría
		private void BtnEliminar_Click(object? sender, EventArgs e)
		{
			if (dgvListaCat.CurrentRow == null)
			{
				MessageBox.Show("Seleccione una categoría para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			int id = (int)dgvListaCat.CurrentRow.Cells["Id"].Value;
			var categoria = _context.Categories.Find(id);

			if (categoria != null)
			{
				if (MessageBox.Show("¿Está seguro de eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_context.Categories.Remove(categoria);
					_context.SaveChanges();
					CargarCategorias();
					LimpiarFormulario();
				}
			}
		}

		private void BtnLimpiar_Click(object? sender, EventArgs e)
		{
			LimpiarFormulario();
		}

		private void LimpiarFormulario()
		{
			txtNombreCat.Clear();
			cbTipoCat.SelectedIndex = -1;
			nupdownLimiteCat.Value = nupdownLimiteCat.Minimum;
		}
	}
}

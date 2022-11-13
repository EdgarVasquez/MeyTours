using MeyTours.Capa_Logica;
using MeyTours.CapaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeyTours.Capa_Visual
{
	public partial class Chofer : Form
	{
		int Id;
		ChoferEntity entity;
		public Chofer()
		{
			InitializeComponent();
		}
		private void limpiar()
		{
			TXTNombre.Clear();
			TXTApellido.Clear();
			TXTCedula.Clear();
			dateTimePicker1.Value = DateTime.Now;
		}
		private void Chofer_Load(object sender, EventArgs e)
		{

		}
		private void CargarEntidad()
		{
			entity = new ChoferEntity();
			entity.Nombre = TXTNombre.Text;
			entity.Apellido = TXTApellido.Text;
			entity.Cedula = TXTCedula.Text;
			entity.FechaDeNacimiento = dateTimePicker1.Value.ToString();
			entity.Id = Id;

		}
		private void Search()
		{
			var x = new CapaDeDatos.DataSet1TableAdapters.ChoferesTableAdapter();
			dataGridView1.DataSource = x.GetData();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			ChoferLogic ChoferLogic = new ChoferLogic();
			bool respuesta = ChoferLogic.Crear(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Creado con exito");
				limpiar();
				Search();
			}
			else
			{
				MessageBox.Show("Ha ocurrido un error");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			ChoferLogic ChoferLogic = new ChoferLogic();
			bool respuesta = ChoferLogic.Editar(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Editado con exito");
				limpiar();
				Search();
			}
			else
			{
				MessageBox.Show("Ha ocurrido un error");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			ChoferLogic ChoferLogic = new ChoferLogic();
			bool respuesta = ChoferLogic.Eliminar(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Eliminado con exito");
				limpiar();
				Search();
			}
			else
			{
				MessageBox.Show("Ha ocurrido un error");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			TXTNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			TXTApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
			TXTCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
		}
	}
}

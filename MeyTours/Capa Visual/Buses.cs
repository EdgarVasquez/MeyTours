using MeyTours.Capa_Logica;
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
	public partial class Buses : Form
	{
		int Id; 
		BusesEntity entity;
		public Buses()
		{
			InitializeComponent();
		}
		private void CargarEntidad()
		{
			entity = new BusesEntity();
			entity.Marca = TXTMarca.Text;
			entity.Modelo = TXTModelo.Text;
			entity.Placa = TXTPlaca.Text;
			entity.Año = TXTAÑO.Text;
			entity.Color = TXTCOLOR.Text;
			entity.Id = Id;

		}
		private void Buses_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			BusesLogic busesLogic = new BusesLogic();
			bool respuesta = busesLogic.Crear(entity);
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

		private void button5_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void Search()
		{
			var x = new CapaDeDatos.DataSet1TableAdapters.BusesTableAdapter();
			dataGridView1.DataSource = x.GetData();
		}
		private void limpiar()
		{
			TXTMarca.Clear();
			TXTModelo.Clear();
			TXTCOLOR.Clear();
			TXTAÑO.Clear();
			TXTPlaca.Clear();
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			TXTMarca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			TXTModelo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			TXTPlaca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			TXTCOLOR.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			TXTAÑO.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			BusesLogic busesLogic = new BusesLogic();
			bool respuesta = busesLogic.Editar(entity);
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
			BusesLogic busesLogic = new BusesLogic();
			bool respuesta = busesLogic.Eliminar(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Elimnado con exito");
				limpiar();
				Search();
			}
			else
			{
				MessageBox.Show("Ha ocurrido un error");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			limpiar();
		}
	}
}

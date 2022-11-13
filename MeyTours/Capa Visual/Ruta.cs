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
	public partial class Ruta : Form
	{
		int Id;
		RutaEntity entity;
		public Ruta()
		{
			InitializeComponent();
		}
		private void CargarEntidad()
		{
			entity = new RutaEntity();
			entity.Descripcion = TXTDescripcion.Text;
			
			entity.Id = Id;

		}
		private void Search()
		{
			var x = new CapaDeDatos.DataSet1TableAdapters.RutaTableAdapter();
			dataGridView1.DataSource = x.GetData();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			RutaLogic RutaLogic = new RutaLogic();
			bool respuesta = RutaLogic.Crear(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Creado con exito");
				TXTDescripcion.Clear();
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
			RutaLogic RutaLogic = new RutaLogic();
			bool respuesta = RutaLogic.Editar(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Editado con exito");
				TXTDescripcion.Clear();
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
			RutaLogic RutaLogic = new RutaLogic();
			bool respuesta = RutaLogic.Eliminar(entity);
			if (respuesta == true)
			{
				MessageBox.Show("Elimado con exito");
				TXTDescripcion.Clear();
				Search();
			}
			else
			{
				MessageBox.Show("Ha ocurrido un error");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			TXTDescripcion.Clear();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			TXTDescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
		}
	}
}

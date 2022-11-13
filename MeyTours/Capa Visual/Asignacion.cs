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
	public partial class Asignacion : Form
	{
		int Id;
		AsignacionEntity entity;
		public Asignacion()
		{
			InitializeComponent();
		}
		private void CargarEntidad()
		{
			entity = new AsignacionEntity();
			entity.IdBus = Convert.ToInt32(comboBox1.SelectedValue);
			entity.IdChofer = Convert.ToInt32(comboBox2.SelectedValue);
			entity.IdRuta = Convert.ToInt32(comboBox3.SelectedValue);
			entity.ID = Id;

		}
		private void Asignacion_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.Ruta' Puede moverla o quitarla según sea necesario.
			this.rutaTableAdapter.Fill(this.dataSet1.Ruta);
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.Choferes' Puede moverla o quitarla según sea necesario.
			this.choferesTableAdapter.Fill(this.dataSet1.Choferes);
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.Buses' Puede moverla o quitarla según sea necesario.
			this.busesTableAdapter.Fill(this.dataSet1.Buses);

		}
		private void Search()
		{
			var x = new CapaDeDatos.DataSet1TableAdapters.AsignacionViewTableAdapter();
			dataGridView1.DataSource = x.GetData();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			AsignacionLogic AsignacionLogic = new AsignacionLogic();
			string respuesta = AsignacionLogic.Crear(entity);
			MessageBox.Show(respuesta);
			Search();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			AsignacionLogic AsignacionLogic = new AsignacionLogic();
			string respuesta = AsignacionLogic.Editar(entity);
			MessageBox.Show(respuesta);
			Search();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CargarEntidad();
			AsignacionLogic AsignacionLogic = new AsignacionLogic();
			string respuesta = AsignacionLogic.Eliminar(entity);
			MessageBox.Show(respuesta);
			Search();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			var x = new Buses();
			x.ShowDialog();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			var x = new Chofer();
			x.ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			var x = new Ruta();
			x.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.Ruta' Puede moverla o quitarla según sea necesario.
			this.rutaTableAdapter.Fill(this.dataSet1.Ruta);
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.Choferes' Puede moverla o quitarla según sea necesario.
			this.choferesTableAdapter.Fill(this.dataSet1.Choferes);
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.Buses' Puede moverla o quitarla según sea necesario.
			this.busesTableAdapter.Fill(this.dataSet1.Buses);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
			comboBox2.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
			comboBox3.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Search();
		}
	}
}

namespace MeyTours.Capa_Visual
{
	partial class Asignacion
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.busesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new MeyTours.CapaDeDatos.DataSet1();
			this.busesTableAdapter = new MeyTours.CapaDeDatos.DataSet1TableAdapters.BusesTableAdapter();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.choferesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.choferesTableAdapter = new MeyTours.CapaDeDatos.DataSet1TableAdapters.ChoferesTableAdapter();
			this.rutaTableAdapter = new MeyTours.CapaDeDatos.DataSet1TableAdapters.RutaTableAdapter();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.button5.Location = new System.Drawing.Point(28, 14);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(221, 34);
			this.button5.TabIndex = 17;
			this.button5.Text = "Buscar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Location = new System.Drawing.Point(303, 183);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 56);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 251);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(545, 247);
			this.dataGridView1.TabIndex = 32;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.button3.Location = new System.Drawing.Point(336, 132);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 48);
			this.button3.TabIndex = 30;
			this.button3.Text = "Eliminar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.button2.Location = new System.Drawing.Point(459, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 48);
			this.button2.TabIndex = 29;
			this.button2.Text = "Editar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.button1.Location = new System.Drawing.Point(336, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 48);
			this.button1.TabIndex = 28;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Ruta";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Chofer";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(226, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 45);
			this.label2.TabIndex = 18;
			this.label2.Text = "Asignacion";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Bus";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.busesBindingSource;
			this.comboBox1.DisplayMember = "MODELO";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(107, 94);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 21);
			this.comboBox1.TabIndex = 34;
			this.comboBox1.ValueMember = "Id";
			// 
			// busesBindingSource
			// 
			this.busesBindingSource.DataMember = "Buses";
			this.busesBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// busesTableAdapter
			// 
			this.busesTableAdapter.ClearBeforeFill = true;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.choferesBindingSource;
			this.comboBox2.DisplayMember = "Nombre";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(107, 136);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(152, 21);
			this.comboBox2.TabIndex = 35;
			this.comboBox2.ValueMember = "Id";
			// 
			// choferesBindingSource
			// 
			this.choferesBindingSource.DataMember = "Choferes";
			this.choferesBindingSource.DataSource = this.dataSet1;
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.rutaBindingSource;
			this.comboBox3.DisplayMember = "Descripcion";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(107, 187);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(152, 21);
			this.comboBox3.TabIndex = 36;
			this.comboBox3.ValueMember = "Id";
			// 
			// rutaBindingSource
			// 
			this.rutaBindingSource.DataMember = "Ruta";
			this.rutaBindingSource.DataSource = this.dataSet1;
			// 
			// choferesTableAdapter
			// 
			this.choferesTableAdapter.ClearBeforeFill = true;
			// 
			// rutaTableAdapter
			// 
			this.rutaTableAdapter.ClearBeforeFill = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.button4.Location = new System.Drawing.Point(459, 136);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(93, 48);
			this.button4.TabIndex = 37;
			this.button4.Text = "Cargar ComboBox";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Asignacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 508);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Asignacion";
			this.Text = "Asignacion";
			this.Load += new System.EventHandler(this.Asignacion_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private CapaDeDatos.DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource busesBindingSource;
		private CapaDeDatos.DataSet1TableAdapters.BusesTableAdapter busesTableAdapter;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.BindingSource choferesBindingSource;
		private CapaDeDatos.DataSet1TableAdapters.ChoferesTableAdapter choferesTableAdapter;
		private System.Windows.Forms.BindingSource rutaBindingSource;
		private CapaDeDatos.DataSet1TableAdapters.RutaTableAdapter rutaTableAdapter;
		private System.Windows.Forms.Button button4;
	}
}
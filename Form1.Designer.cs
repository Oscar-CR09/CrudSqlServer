namespace CrudSqlServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btneliminar = new Button();
            btnmodificar = new Button();
            btnguardar = new Button();
            txtedad = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtdni = new TextBox();
            txtid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridalumnos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridalumnos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btneliminar);
            groupBox1.Controls.Add(btnmodificar);
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(txtedad);
            groupBox1.Controls.Add(txtapellido);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(txtdni);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 322);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de alumnos";
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(162, 261);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "ELIMINAR";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click_1;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(32, 261);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(92, 23);
            btnmodificar.TabIndex = 11;
            btnmodificar.Text = "MODIFICAR";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnmodificar_Click_1;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(32, 206);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(205, 23);
            btnguardar.TabIndex = 10;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(101, 157);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(161, 23);
            txtedad.TabIndex = 9;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(101, 120);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(161, 23);
            txtapellido.TabIndex = 8;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(101, 90);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(161, 23);
            txtnombre.TabIndex = 7;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(101, 62);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(161, 23);
            txtdni.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.Location = new Point(101, 30);
            txtid.Name = "txtid";
            txtid.Size = new Size(161, 23);
            txtid.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 165);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "EDAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 128);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "APELLIDO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 98);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // dataGridalumnos
            // 
            dataGridalumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridalumnos.Location = new Point(306, 32);
            dataGridalumnos.Name = "dataGridalumnos";
            dataGridalumnos.RowTemplate.Height = 25;
            dataGridalumnos.Size = new Size(437, 322);
            dataGridalumnos.TabIndex = 1;
            dataGridalumnos.CellMouseClick += dataGridalumnos_CellMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 369);
            Controls.Add(dataGridalumnos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridalumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridalumnos;
        private Button btneliminar;
        private Button btnmodificar;
        private Button btnguardar;
        private TextBox txtedad;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtdni;
        private TextBox txtid;
    }
}
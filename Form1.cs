namespace CrudSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.Calumnos objetoalumnos = new Clases.Calumnos();
            objetoalumnos.mostrarAlumnos(dataGridalumnos);

            txtid.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            Clases.Calumnos objetoalumnos = new Clases.Calumnos();
            objetoalumnos.guardarAlumnos(txtdni, txtnombre, txtapellido, txtedad);
            objetoalumnos.mostrarAlumnos(dataGridalumnos);

            txtid.Text = "";
            txtdni.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";


        }

        private void dataGridalumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.Calumnos objetoalumnos = new Clases.Calumnos();
            objetoalumnos.seleccionarAlumnos(dataGridalumnos, txtid, txtdni, txtnombre, txtapellido, txtedad);
        }


        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            Clases.Calumnos objetoalumnos = new Clases.Calumnos();
            objetoalumnos.eliminarAlumnos(txtid);
            objetoalumnos.mostrarAlumnos(dataGridalumnos);

            txtid.Text = "";
            txtdni.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            Clases.Calumnos objetoalumnos = new Clases.Calumnos();
            objetoalumnos.modificarAlumnos(txtid, txtdni, txtnombre, txtapellido, txtedad);
            objetoalumnos.mostrarAlumnos(dataGridalumnos);

            txtid.Text = "";
            txtdni.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
        }
    }


}
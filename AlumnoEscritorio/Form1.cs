using AlumnoEscritorio.datos;
using AlumnoEscritorio.modelo;
using System.Data;

namespace AlumnoEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == "")
            {
                MessageBox.Show("¡Debe ingresa un nombre!");
            }
            else if (txtNombres.Text.Trim().Length < 5)
            {
                MessageBox.Show("Ingrese un nombre mayor a 5 caracteres ");
            }else
            {
                try
                {
                    Alumno em = new Alumno();
                    em.Nombre = txtNombres.Text.Trim().ToUpper();
                    em.Calificacion = Convert.ToInt32(txtCalificaciones.Text.Trim());
                    if (AlumnoCAD.guardar(em))
                    {
                        MessageBox.Show("¡Alumno(a) guardado correctamente!");
                    }else
                    {
                        MessageBox.Show("¡Ya existe alguien con ese nombre!");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void llenarGrid()
        {
            DataTable datos=AlumnoCAD.listar();
            if(datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }else
            {
                dgLista.DataSource = datos.DefaultView;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
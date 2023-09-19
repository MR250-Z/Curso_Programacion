
using Entidades;
namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona _persona;
        List<Persona> listaPersonas = new List<Persona>();

        private void button1_Click(object sender, EventArgs e)
        {
            _persona = new Persona();

            _persona.Nombre = textBox1.Text;
            _persona.Estatura = Convert.ToDecimal(textBox4.Text);
            _persona.Edad = DevolverEdad(dateTimePicker1.Value);
            _persona.Genero = textBox2.Text;
            _persona.FechaNac = dateTimePicker1.Value;
            textBox3.Text = _persona.Edad.ToString();
            listaPersonas.Add(_persona);
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = listaPersonas;
            Limpiar();

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = listaPersonas;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_persona.DevolveraDatosDeLaPersona());
        }


        private void Limpiar()
        {
            _persona = null;
            textBox1.Text = string.Empty;
            textBox4.Clear();
            textBox3.Text = "";
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private int DevolverEdad(DateTime FechaNac)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (FechaNac >= fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - FechaNac.Year;
                if (FechaNac.Month >= fechaActual.Month)
                    edad--;

            }
            return edad;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


    }
}
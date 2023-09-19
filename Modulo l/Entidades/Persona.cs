

namespace Entidades
{
    public class Persona
    {

        //Atributos
        private string nombre;
        //private string estatura;
        //private int edad;
        //private string genero;
        //private DateTime fechaNac;

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Estatura { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNac { get; set;}

        //Constructores

        public Persona() { }


        public Persona (string nombre, DateTime fechaNac)
        {
            Nombre = nombre;
            FechaNac = fechaNac;
        }

        public Persona(string nombre, decimal estatura, int edad, string genero, DateTime fechaNac)
        {
            Nombre = nombre;
            Estatura = estatura;
            Edad = edad;
            Genero = genero;
            FechaNac = fechaNac;
        }


        // Metodos (Funciones, Acciones)

        public string DevolveraDatosDeLaPersona()
        {
            return "Nombre: " + Nombre + ", Edad" + Edad + ", Genero" + Genero;
        }

        //Constructores

    }
}

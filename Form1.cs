using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaconobjetos
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            //instanciar la clase persona
            Persona persona = new Persona();

            //Guardo los datos de una persona
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = monthCalendarNacimiento.SelectionStart;

            //Mandar a guardar a la persona a la lista de personas
            personas.Add(persona);
        }

        private void Mostrar ()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
            dataGridView1.Refresh();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
           Mostrar();
        }

        private void btnOrdenarApellido_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Apellido).Tolist();
            Mostrar();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string dpi = textBoxDpi.Text;

            personas.RemoveAll(p => p.Dpi == dpi);

            Mostrar();

        }

        private void buttonOdenarDes_Click(object sender, EventArgs e)
        {
            personas.OrderByDescending(p => p.Apellido);
            Mostrar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Personas.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < personas.Count; i++)
            {
                writer.WriteLine(personas[i].Dpi);
                writer.WriteLine(personas[i].Nombre);
                writer.WriteLine(personas[i].Apellido);
                writer.WriteLine(personas[i].FechaNacimiento);

            }

            writer.Close();
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            string fileName = "Personas.txt";

            
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
            {
                Persona persona = new Persona();
                
                persona.Dpi = reader.ReadLine();
                persona.Nombre = reader.ReadLine();
                persona.Apellido = reader.ReadLine();
                persona.FechaNacimiento = Convert.ToDateTime(reader.ReadLine());    

                personas.Add(persona);
            }

            reader.Close();
            Mostrar();
        }
    }
}

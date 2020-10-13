using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cGrupo.Items.Add("1 O");
            cGrupo.Items.Add("1 A");
            cGrupo.Items.Add("1 T");
            cGrupo.Items.Add("1 P");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno(cNombre.Text, cApellidos.Text, Convert.ToDateTime(cFechaNacimineto.Text), cGrupo.SelectedItem.ToString());
            cNombre.Text = " ";
            cApellidos.Text = " ";
            cFechaNacimineto.Text = " ";


            cListaAlumnos.AppendText("Alumno " + miAlumno.nombre + " " + miAlumno.apellidos + "  Nacido el " + miAlumno.fechaNacimiento + " del grupo " + miAlumno.grupo);

        }
    }
}

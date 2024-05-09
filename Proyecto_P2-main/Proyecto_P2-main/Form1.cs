using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Nombre: José Carlos Pérez Valencia
//Matricula: DI22140
//Examen de segundo parcial de la materia "Programacion orientada a objetos II"


namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e) //esta parte del codigo fue un reeciclaje de la actividad del cajero automatico
        {
            MessageBox.Show("Los datos han sido guardados correctamente");// esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
        }

        private void limpiar_Click(object sender, EventArgs e) //de igual manera que se hizo con el codigo del boton "guardar" (reciclando el codigo que se ocupo para el cajero automatico)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();// se hace de tarea
            // debe de borrar las cajas de texto
        }

        private void Salir_Click(object sender, EventArgs e) //de igual manera que se aplico en limpiar y guardar, se hizo este codigo
        {
            Application.Exit();// se hace de tarea
            // debe de terminar la ejecucion de la interfaz
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void validar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

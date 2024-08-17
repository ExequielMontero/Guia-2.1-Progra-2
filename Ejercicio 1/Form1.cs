using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular midepartamento = new DepartamentoVehicular();
        Datos persona = new Datos();
        int cont = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lbRegistro.Items.Clear();
            if(persona.ShowDialog() == DialogResult.OK)
            {
                string nombre = persona.tbNombre.Text;
                int dni = Convert.ToInt32(persona.tbDni.Text);
                Persona mipersona = new Persona(dni, nombre);
                char letra1 = midepartamento.GenerarPatente();
                char letra2 = midepartamento.GenerarPatente();
                string formato = "000";
                string actual = midepartamento.CantidadRegistros.ToString(formato);
                string patente = ($"{letra1}{letra2}{actual}");
                string formatoserie = "000000000";
                string nmroserie = cont.ToString(formatoserie);
                midepartamento.RegistrarVehiculo(mipersona, patente, nmroserie);
                lbRegistro.Items.Add($"Nmro de Serie: {nmroserie}");
                lbRegistro.Items.Add($"Nmro de Patente: {patente}");
                lbRegistro.Items.Add($"Nombre: {nombre}, Dni: {dni}");
                lbRegistro.Items.Add($"----------------------------------------------------");
                persona.tbDni.Clear();
                persona.tbNombre.Clear();
                cont++;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbListar.Items.Clear();
            Registrar actual;
            for(int i=0; i < midepartamento.CantidadRegistros; i++)
            {
                actual = midepartamento.VerRegistro(i);
                lbListar.Items.Add($"Nmro de Serie: {actual.serie}");
                lbListar.Items.Add($"Nmro de Patente: {actual.patente}");
                lbListar.Items.Add($"Nombre: {actual.dueño.nombre}, Dni: {actual.dueño.dni}");
                lbListar.Items.Add($"----------------------------------------------------");
            }
        }
    }
}

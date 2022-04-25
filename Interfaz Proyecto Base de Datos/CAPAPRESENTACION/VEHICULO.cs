using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Instanciar 
using Interfaz_Proyecto_Base_de_Datos.CAPADATOS;


namespace Interfaz_Proyecto_Base_de_Datos.CAPAPRESENTACION
{
    public partial class VEHICULO : Form
    {
        ClsVehiculo objVehiculo = new ClsVehiculo();
        public VEHICULO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VEHICULO_Load(object sender, EventArgs e)
        {
            ListarCliente();
            ListarMecanicos();
            ListarTaller();
            ListarAutomoviles();

        }

        private void ListarCliente()
        {
            ClsVehiculo objVehiculo = new ClsVehiculo();
            cmbCliente.DataSource = objVehiculo.ListarCliente();
            cmbCliente.DisplayMember = "p_nombre";
            cmbCliente.ValueMember = "idCliente";

        }

        private void ListarTaller()
        {
            ClsVehiculo objVehicu = new ClsVehiculo();
            cmbTaller.DataSource = objVehicu.ListarTaller();
            cmbTaller.DisplayMember = "nombreTaller";
            cmbTaller.ValueMember = "idTaller";

        }

        private void ListarMecanicos()
        {
            ClsVehiculo objVehicul = new ClsVehiculo();
            cmbMecanico.DataSource = objVehicul.ListarMecanicos();
            cmbMecanico.DisplayMember = "p_nombre";
            cmbMecanico.ValueMember = "idMecanico";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            objVehiculo.InsertarVehiculos(
                (string)cmbCliente.SelectedValue,
                (string)cmbMecanico.SelectedValue,
                Convert.ToInt32(cmbTaller.SelectedValue),
                txtPlaca.Text, txtMarca.Text, txtModelo.Text, 
                txtBin.Text, txtColor.Text,
                Convert.ToDateTime(txtHora.Text));

            MessageBox.Show("Vehiculo insertado Correctamente");
            ListarAutomoviles();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void ListarAutomoviles()
        {
            ClsVehiculo objVeh = new ClsVehiculo();
            dataGridView1.DataSource = objVeh.ListarAutomoviles();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Proyecto_Base_de_Datos.CAPAPRESENTACION
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            costumizeDesign();
        }

        private void costumizeDesign()
        {
            panelSubMenuAdmin.Visible = false;
            panelCita.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuAdmin.Visible == true)
                panelSubMenuAdmin.Visible = false;
            if (panelCita.Visible == true)
                panelCita.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Abrir formulario Cliente
            //
            //
            Form formularioCliente = new Cliente();
            formularioCliente.Show();
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Abrir formulario Asesor
            //
            //
            hideSubMenu();
        }

        private void btnMec_Click(object sender, EventArgs e)
        {
            //Abrir formulario Mecanico
            //
            //
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCita);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abrir formulario CitaReparacion
            //
            //
            hideSubMenu();
        }

        private void Lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonAdministrar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAdmin);
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            //Abrir formulario Taller
            //
            //
            hideSubMenu();
        }

        private void btnCupo_Click(object sender, EventArgs e)
        {
            //Abrir formulario Cupo
            //
            //
            hideSubMenu();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            //Abrir formulario Vehiculo
            //
            //
            Form formularioVehiculo = new VEHICULO();
            formularioVehiculo.Show();
            hideSubMenu();
            hideSubMenu();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //Abrir formulario tipo Empleado
            //
            //
            hideSubMenu();
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            //Abrir formulario cita Diagnostico
            //
            //
            hideSubMenu();
        }

        private void panelCita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaRec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtIdPersona.Text = "";
            txtNombre.Text = "";
            if (chkTrabaja.Checked)
            {
                chkTrabaja.Checked = false;
            }
            DateTime dtpNació = DateTime.Today;
           
        }
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            trabajadores oTrabajadores = new trabajadores();
            oTrabajadores.trabajador = Convert.ToInt32(txtIdPersona.Text);
            oTrabajadores.Nombre = txtNombre.Text;
            if (radFemenino.Checked)
            {
                oTrabajadores.Sexo = "F";
            }
            else
            {
                oTrabajadores.Sexo = "M";
            }
            if (chkTrabaja.Checked)
            {
                oTrabajadores.Trabaja = 1;
            }
            else
            {
                oTrabajadores.Trabaja = 0; 
            }
             
            oTrabajadores.grabar();
            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            trabajadores oTrabajadores = new trabajadores();
            oTrabajadores.trabajador = Convert.ToInt32(txtIdPersona.Text);
            oTrabajadores.Nombre = txtNombre.Text;
            if (radFemenino.Checked)
            {
                oTrabajadores.Sexo = "F";
            }
            else
            {
                oTrabajadores.Sexo = "M";
            }
            if (chkTrabaja.Checked)
            {
                oTrabajadores.Trabaja = 1;
            }
            else
            {
                oTrabajadores.Trabaja = 0;
            }

            oTrabajadores.eliminar();
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            trabajadores oTrabajadores = new trabajadores();
            oTrabajadores.modificar(1, oTrabajadores.Nombre, oTrabajadores.Sexo, oTrabajadores.Trabaja,oTrabajadores.Nacio, 2);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Suponiendo que esta sección de código está en algún evento asociado al cambio del txtPersonaID
            trabajadores oTrabajadores = new trabajadores();
            int personaID = Convert.ToInt32(txtIdPersona.Text);
            oTrabajadores.buscar(personaID, txtNombre, radFemenino, radMasculino, chkTrabaja);


        }
    }
}

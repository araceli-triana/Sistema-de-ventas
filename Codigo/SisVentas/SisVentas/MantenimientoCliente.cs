using Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas
{
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaClientes '{0}','{1}','{2}'",txtIdCli.Text.Trim(), 
                                           txtNomCli.Text.Trim(), txtApeCli.Text.Trim());
                //campos que ocuparan cada una de las posiciones
                Utilizar.Ejecutar(cmd);
                MessageBox.Show("Se ha guardado correctamente el cliente!...");
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
                return false;
            }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarClientes '{0}'", txtIdCli.Text.Trim());
                Utilizar.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el cliente");
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
            }
        }
    }
}

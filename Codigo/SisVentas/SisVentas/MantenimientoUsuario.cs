using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace SisVentas
{
    public partial class MantenimientoUsuario : Mantenimiento
    {
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }
        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaUsuario '{0}','{1}','{2}','{3}'", txtIdUsu.Text.Trim(),
                                           txtNomUsu.Text.Trim(), txtCuentaUsu.Text.Trim(), txtContraseñaUsu.Text.Trim());
                //campos que ocuparan cada una de las posiciones
                Utilizar.Ejecutar(cmd);
                MessageBox.Show("Se ha guardado correctamente el Usuario!...");
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
                string cmd = string.Format("EXEC EliminarUsuario '{0}'", txtIdUsu.Text.Trim());
                Utilizar.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el Usuario");
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
            }
        }
    }
}

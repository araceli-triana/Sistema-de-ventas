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
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (Utilizar.ValidarFormulario(this, errorProvider1) == false)
            {//antes de realizar el proceso valida el formulario, si es false solo regresara un false

            try
            {
                string cmd = string.Format("EXEC ActualizaArticulos '{0}','{1}','{2}'", txtIdPro.Text.Trim(),
                                            txtNomPro.Text.Trim(), txtPrecio.Text.Trim());
                //campos que ocuparan cada una de las posiciones
                Utilizar.Ejecutar(cmd);
                MessageBox.Show("Se ha guardado correctamente el producto!...");
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
                return false;
            }
        }
        else
        {
                return false;
        }
    }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtIdPro.Text.Trim());
                Utilizar.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
            }
        }

        private void txtIdPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //cuando la persona ingrese nuevamente un producto lo limpie
        }
    }
}

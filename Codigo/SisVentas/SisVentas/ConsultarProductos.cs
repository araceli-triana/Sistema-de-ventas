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
    public partial class ConsultarProductos : Consultas
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                string cmd = "SELECT * FROM Articulo WHERE NombreProducto LIKE ('%" + textBox1.Text.Trim() + "%')";
                //SELECIONAR DE LA TABLA CLIENTE DONDE EL NOMBRE DEL CLIENTE PUEDE SER COMO LA LETRA QUE SE DIGITA
                ds = Utilizar.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
            }
        }

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("Articulo").Tables[0];
        }
    }
}

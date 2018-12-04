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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public DataSet LLenarDataGV(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            DS = Utilizar.Ejecutar(cmd);
            return DS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {//si en el datagridview no hay nada que regrese
                return;
            }
            else //en caso contrario, que exista una fila
            {
                DialogResult = DialogResult.OK; //el resultado sera un dialogo con ok
                Close(); //cerrar ventana
            }
        }
    }
}

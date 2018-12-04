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
    public partial class VentanaUsuario : FormBase
    {
        public VentanaUsuario()
        {
            InitializeComponent();
        }

        private void VentanaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUsuario_Load(object sender, EventArgs e)
        {
            string cmd = "select * FROM Usuarios WHERE IdUsuario=" + VentanaLogin.Codigo;
            DataSet ds = Utilizar.Ejecutar(cmd);

            lblNomUs.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString();
            lblUs.Text = ds.Tables[0].Rows[0]["CuentaUsuario"].ToString();
            lblCodigo.Text = ds.Tables[0].Rows[0]["Contraseña"].ToString();
            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void lblNomUs_Click(object sender, EventArgs e)
        {

        }

        private void lblUs_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor_Principal ConP = new Contenedor_Principal();
            this.Hide();
            ConP.Show();
        }
    }
}

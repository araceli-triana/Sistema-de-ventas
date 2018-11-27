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
    public partial class VentanaAdministrador : FormBase
    {
        public VentanaAdministrador()
        {
            InitializeComponent();
        }

        private void VentanaAdministrador_Load(object sender, EventArgs e)
        {
            string cmd = "select * FROM Usuarios WHERE IdUsuario=" + VentanaLogin.Codigo;
            DataSet ds = Utilizar.Ejecutar(cmd);

            lblNomAd.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString();
            lblUsAdmid.Text = ds.Tables[0].Rows[0]["CuentaUsuario"].ToString();
            lblCodigo.Text = ds.Tables[0].Rows[0]["Contraseña"].ToString();
            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void VentanaAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Contenedor_Principal ConP = new Contenedor_Principal();
            this.Hide();
            ConP.Show();
        }
    }
}

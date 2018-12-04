using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Libreria;
using System.Data;

namespace SisVentas
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //COLOCA EN EL CERO  Y UNO LO QUE SE ALMACENO EN LOS REGISTROS CUENTA Y CONTRASEÑA
                string cmd = string.Format("select * FROM Usuarios WHERE CuentaUsuario='{0}' AND Contraseña='{1}'",
                txtNomcuenta.Text.Trim(), txtContraseña.Text.Trim());
                // se guarda en DS lo que se pide en la sentencia sql anterior
               
                DataSet ds = Utilizar.Ejecutar(cmd);
                Codigo = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();//codigo para usuario que esta intentando conectarse

                string cuenta = ds.Tables[0].Rows[0]["CuentaUsuario"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();

                if (cuenta == txtNomcuenta.Text.Trim() && contraseña == txtContraseña.Text.Trim())
                {
                   if (Convert.ToBoolean(ds.Tables[0].Rows[0]["StatusAdmin"])== true)
                    {
                        VentanaAdministrador VenAd = new VentanaAdministrador();
                        this.Hide();
                        VenAd.Show();
                    }
                    //MessageBox.Show("SE HA INICIADO SESION");
                }
                else
                {
                    VentanaUsuario VenUsu = new VentanaUsuario();
                    this.Hide();
                    VenUsu.Show();
                }
                /*else
                {
                    MessageBox.Show("OOOPSSS!!!!.......USUARIO O CONTRASEÑA INCORRECT@");
                }*/

            }
            catch (Exception Error)
            {
                MessageBox.Show("OOOPSSS!!!!\n.......USUARIO O CONTRASEÑA INCORRECT@!!!" );
            }
            /*
             try
             {
                 SqlConnection Con = new SqlConnection("Data Source =.; Initial Catalog = SistemaV; Integrated Security = True");
                 Con.Open();//ABRIR CONEXION DE FORMA LOCAL A LA BASE DE DATOS           NOMBRE DE BD, ACCESO SIN CONTRASEÑA.
                 MessageBox.Show("AHORA ESTAS CONECTADO A LA BASE DE DATOS");
             }
             catch (Exception Error)
             {
                 MessageBox.Show("HA OCURRIDO UN ERROR:" + Error.Message);
                 //SI  LOS DSTOS DE LA CONECCION NO ESTAN CORRECTOS, MANDARA UN MENSAJE DE ERROR 

             }*/
            Utilizar.Ejecutar("select * FROM Cliente WHERE IdCliente =1");
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

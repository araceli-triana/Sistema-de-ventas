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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios Where IdUsuario =" + VentanaLogin.Codigo;
            DataSet ds;
            ds = Utilizar.Ejecutar(cmd);

            lblLeAtiende.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("select NombreCliente from Cliente Where IdCliente='{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilizar.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["NombreCliente"].ToString().Trim();
                    txtCodigoPro.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido un error: " + Error.Message);
            }
        }

        public static int contFila = 0;
        public static double total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilizar.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int numFila = 0;

                if (contFila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contFila].Cells[2].Value)
                        * Convert.ToDouble(dataGridView1.Rows[contFila].Cells[3].Value);
                    dataGridView1.Rows[contFila].Cells[4].Value = importe;

                    contFila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == txtCodigoPro.Text)
                        {
                            existe = true;
                            numFila = fila.Index;

                        }
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[numFila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) +
                            Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value)).ToString();

                        double importe = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[2].Value)
                            * Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);

                        dataGridView1.Rows[numFila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);

                        double importe = Convert.ToDouble(dataGridView1.Rows[contFila].Cells[2].Value)
                            * Convert.ToDouble(dataGridView1.Rows[contFila].Cells[3].Value);

                        dataGridView1.Rows[contFila].Cells[4].Value = importe;

                        contFila++;
                    }
                }

                total = 0;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);

                }
                lblTotal.Text = "MX$ " + total.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contFila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "MX$ " + total.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                contFila--;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();
            ConCli.ShowDialog();
            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCodigoPro.Focus();

            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConPro = new ConsultarProductos();
            ConPro.ShowDialog();
            if (ConPro.DialogResult == DialogResult.OK)
            {
                txtCodigoPro.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCantidad.Focus();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            txtCodigoCli.Text = "";
            txtCliente.Text = "";
            txtCodigoPro.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lblTotal.Text = "MX$ 0.00";
            dataGridView1.Rows.Clear();
            contFila = 0;
            total = 0;
            txtCodigoCli.Focus();
        }
    }
}
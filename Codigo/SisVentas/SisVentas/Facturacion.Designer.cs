namespace SisVentas
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnColocar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.lblLeAtiende = new System.Windows.Forms.Label();
            this.txtCantidad = new Libreria.ErrorTxtBox();
            this.txtPrecio = new Libreria.ErrorTxtBox();
            this.txtDescripcion = new Libreria.ErrorTxtBox();
            this.txtCodigoPro = new Libreria.ErrorTxtBox();
            this.txtCliente = new Libreria.ErrorTxtBox();
            this.txtCodigoCli = new Libreria.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(754, 463);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(658, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnColocar
            // 
            this.btnColocar.Location = new System.Drawing.Point(754, 143);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(138, 37);
            this.btnColocar.TabIndex = 2;
            this.btnColocar.Text = "Colocar";
            this.btnColocar.UseVisualStyleBackColor = true;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(754, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(754, 250);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(138, 37);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(754, 303);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(138, 37);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(754, 356);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(138, 37);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(754, 408);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(138, 37);
            this.btnFacturar.TabIndex = 7;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
            this.dataGridView1.Location = new System.Drawing.Point(15, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 323);
            this.dataGridView1.TabIndex = 8;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 110;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 110;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 110;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Le Atiende:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(519, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 27);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(118, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.MenuText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(15, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(324, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.MenuText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(434, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.MenuText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(550, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "Importe";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(265, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblLeAtiende
            // 
            this.lblLeAtiende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeAtiende.Location = new System.Drawing.Point(79, 11);
            this.lblLeAtiende.Name = "lblLeAtiende";
            this.lblLeAtiende.Size = new System.Drawing.Size(100, 23);
            this.lblLeAtiende.TabIndex = 27;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(429, 111);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(79, 20);
            this.txtCantidad.SoloNumeros = false;
            this.txtCantidad.TabIndex = 25;
            this.txtCantidad.Validar = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(308, 111);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(115, 20);
            this.txtPrecio.SoloNumeros = false;
            this.txtPrecio.TabIndex = 24;
            this.txtPrecio.Validar = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 111);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtDescripcion.SoloNumeros = false;
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.Validar = true;
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Location = new System.Drawing.Point(15, 111);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(89, 20);
            this.txtCodigoPro.SoloNumeros = false;
            this.txtCodigoPro.TabIndex = 22;
            this.txtCodigoPro.Validar = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(79, 71);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(311, 20);
            this.txtCliente.SoloNumeros = false;
            this.txtCliente.TabIndex = 21;
            this.txtCliente.Validar = true;
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Location = new System.Drawing.Point(79, 42);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(162, 20);
            this.txtCodigoCli.SoloNumeros = false;
            this.txtCodigoCli.TabIndex = 20;
            this.txtCodigoCli.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(959, 536);
            this.Controls.Add(this.lblLeAtiende);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoPro);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigoCli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnColocar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnColocar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnClientes, 0);
            this.Controls.SetChildIndex(this.btnProductos, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtCodigoCli, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtCodigoPro, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblLeAtiende, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Libreria.ErrorTxtBox txtCodigoCli;
        private Libreria.ErrorTxtBox txtCliente;
        private Libreria.ErrorTxtBox txtCodigoPro;
        private Libreria.ErrorTxtBox txtDescripcion;
        private Libreria.ErrorTxtBox txtPrecio;
        private Libreria.ErrorTxtBox txtCantidad;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblLeAtiende;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
    }
}
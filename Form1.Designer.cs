namespace ProyectoFinalProgramacion1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.dbView = new System.Windows.Forms.DataGridView();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.nudCodArticulo = new System.Windows.Forms.NumericUpDown();
            this.ColCodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudFactura = new System.Windows.Forms.NumericUpDown();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(682, 378);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 50);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir Pedido";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.Location = new System.Drawing.Point(542, 378);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(111, 50);
            this.btnCargarPedido.TabIndex = 1;
            this.btnCargarPedido.Text = "Cargar Pedido";
            this.btnCargarPedido.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(414, 378);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 50);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = " Borrar Articulo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(281, 378);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(111, 50);
            this.btnCargarProducto.TabIndex = 3;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(831, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 50);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(23, 157);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(103, 20);
            this.lblCodigoArticulo.TabIndex = 6;
            this.lblCodigoArticulo.Text = "Cod. Articulo:";
            this.lblCodigoArticulo.Click += new System.EventHandler(this.lblCodigoArticulo_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(23, 200);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(23, 242);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(23, 288);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(153, 244);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(124, 26);
            this.txtDescripcion.TabIndex = 12;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(23, 328);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(91, 20);
            this.lblDescuento.TabIndex = 14;
            this.lblDescuento.Text = "Descuento:";
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodArticulo,
            this.ColDescripcion,
            this.ColCantidad,
            this.ColPrecio,
            this.ColDescuento,
            this.ColTotal});
            this.dbView.Location = new System.Drawing.Point(296, 12);
            this.dbView.Name = "dbView";
            this.dbView.Size = new System.Drawing.Size(645, 336);
            this.dbView.TabIndex = 17;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(153, 200);
            this.nudCantidad.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(124, 20);
            this.nudCantidad.TabIndex = 18;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(153, 288);
            this.nudPrecio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(124, 20);
            this.nudPrecio.TabIndex = 19;
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(153, 328);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(124, 20);
            this.nudDescuento.TabIndex = 20;
            // 
            // nudCodArticulo
            // 
            this.nudCodArticulo.Location = new System.Drawing.Point(153, 157);
            this.nudCodArticulo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCodArticulo.Name = "nudCodArticulo";
            this.nudCodArticulo.Size = new System.Drawing.Size(124, 20);
            this.nudCodArticulo.TabIndex = 21;
            // 
            // ColCodArticulo
            // 
            this.ColCodArticulo.HeaderText = "Codigo del Articulo";
            this.ColCodArticulo.Name = "ColCodArticulo";
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            // 
            // ColDescuento
            // 
            this.ColDescuento.HeaderText = "Descuento";
            this.ColDescuento.Name = "ColDescuento";
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "SubTotal";
            this.ColTotal.Name = "ColTotal";
            // 
            // nudFactura
            // 
            this.nudFactura.Location = new System.Drawing.Point(153, 67);
            this.nudFactura.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudFactura.Name = "nudFactura";
            this.nudFactura.Size = new System.Drawing.Size(124, 20);
            this.nudFactura.TabIndex = 23;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(23, 67);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(68, 20);
            this.lblFactura.TabIndex = 22;
            this.lblFactura.Text = "Factura:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(153, 108);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(124, 26);
            this.txtRazonSocial.TabIndex = 25;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(23, 106);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(107, 20);
            this.lblRazonSocial.TabIndex = 24;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.nudFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.nudCodArticulo);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.dbView);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargarPedido);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.DataGridView dbView;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.NumericUpDown nudCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.NumericUpDown nudFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
    }
}


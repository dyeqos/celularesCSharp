namespace CapaPresentacion
{
    partial class frmAgregaCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompraCancelar = new System.Windows.Forms.Button();
            this.btnCompraAceptar = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grupoDetalle = new System.Windows.Forms.GroupBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.txtCodCelular = new System.Windows.Forms.ComboBox();
            this.btnDetalleAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerminarTodo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDetalleCompras = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.grupoDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelTitulo.Controls.Add(this.label6);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1209, 27);
            this.panelTitulo.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(24, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agregar Compras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(528, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 135;
            this.label5.Text = "*";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label41.Location = new System.Drawing.Point(452, 59);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(14, 18);
            this.label41.TabIndex = 134;
            this.label41.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "PROVEEDOR";
            // 
            // btnCompraCancelar
            // 
            this.btnCompraCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompraCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnCompraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnCompraCancelar.Location = new System.Drawing.Point(449, 151);
            this.btnCompraCancelar.Name = "btnCompraCancelar";
            this.btnCompraCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCompraCancelar.TabIndex = 137;
            this.btnCompraCancelar.Text = "CANCELAR";
            this.btnCompraCancelar.UseVisualStyleBackColor = true;
            this.btnCompraCancelar.Click += new System.EventHandler(this.btnCompraCancelar_Click);
            // 
            // btnCompraAceptar
            // 
            this.btnCompraAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompraAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            this.btnCompraAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            this.btnCompraAceptar.Location = new System.Drawing.Point(354, 151);
            this.btnCompraAceptar.Name = "btnCompraAceptar";
            this.btnCompraAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnCompraAceptar.TabIndex = 136;
            this.btnCompraAceptar.Text = "ACEPTAR";
            this.btnCompraAceptar.UseVisualStyleBackColor = true;
            this.btnCompraAceptar.Click += new System.EventHandler(this.btnCompraAceptar_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.FormattingEnabled = true;
            this.txtProveedor.Location = new System.Drawing.Point(182, 60);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(340, 21);
            this.txtProveedor.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "FECHA COMPRA";
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.CustomFormat = "dd-MM-yyyy";
            this.txtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaCompra.Location = new System.Drawing.Point(182, 96);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Size = new System.Drawing.Size(340, 20);
            this.txtFechaCompra.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "CELULAR";
            // 
            // grupoDetalle
            // 
            this.grupoDetalle.Controls.Add(this.txtPrecioCompra);
            this.grupoDetalle.Controls.Add(this.txtImei);
            this.grupoDetalle.Controls.Add(this.txtCodCelular);
            this.grupoDetalle.Controls.Add(this.btnDetalleAgregar);
            this.grupoDetalle.Controls.Add(this.label7);
            this.grupoDetalle.Controls.Add(this.label10);
            this.grupoDetalle.Controls.Add(this.label9);
            this.grupoDetalle.Controls.Add(this.label8);
            this.grupoDetalle.Controls.Add(this.label4);
            this.grupoDetalle.Controls.Add(this.label3);
            this.grupoDetalle.Enabled = false;
            this.grupoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.grupoDetalle.Location = new System.Drawing.Point(57, 192);
            this.grupoDetalle.Name = "grupoDetalle";
            this.grupoDetalle.Size = new System.Drawing.Size(518, 184);
            this.grupoDetalle.TabIndex = 141;
            this.grupoDetalle.TabStop = false;
            this.grupoDetalle.Text = "DETALLE COMPRA";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCompra.Location = new System.Drawing.Point(121, 103);
            this.txtPrecioCompra.MaxLength = 25;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(346, 20);
            this.txtPrecioCompra.TabIndex = 128;
            this.txtPrecioCompra.Tag = "1";
            // 
            // txtImei
            // 
            this.txtImei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtImei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImei.ForeColor = System.Drawing.SystemColors.Window;
            this.txtImei.Location = new System.Drawing.Point(123, 69);
            this.txtImei.MaxLength = 25;
            this.txtImei.Name = "txtImei";
            this.txtImei.Size = new System.Drawing.Size(346, 20);
            this.txtImei.TabIndex = 128;
            this.txtImei.Tag = "1";
            // 
            // txtCodCelular
            // 
            this.txtCodCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCodCelular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCodCelular.ForeColor = System.Drawing.Color.White;
            this.txtCodCelular.FormattingEnabled = true;
            this.txtCodCelular.Location = new System.Drawing.Point(123, 31);
            this.txtCodCelular.Name = "txtCodCelular";
            this.txtCodCelular.Size = new System.Drawing.Size(346, 21);
            this.txtCodCelular.TabIndex = 127;
            // 
            // btnDetalleAgregar
            // 
            this.btnDetalleAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalleAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            this.btnDetalleAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            this.btnDetalleAgregar.Location = new System.Drawing.Point(392, 140);
            this.btnDetalleAgregar.Name = "btnDetalleAgregar";
            this.btnDetalleAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleAgregar.TabIndex = 136;
            this.btnDetalleAgregar.Text = "AGREGAR";
            this.btnDetalleAgregar.UseVisualStyleBackColor = true;
            this.btnDetalleAgregar.Click += new System.EventHandler(this.btnDetalleAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 126;
            this.label7.Text = "PRECIO COMPRA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(475, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 18);
            this.label10.TabIndex = 135;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(475, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 135;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(475, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 135;
            this.label8.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "IMEI";
            // 
            // btnTerminarTodo
            // 
            this.btnTerminarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            this.btnTerminarTodo.FlatAppearance.BorderSize = 3;
            this.btnTerminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            this.btnTerminarTodo.Location = new System.Drawing.Point(343, 408);
            this.btnTerminarTodo.Name = "btnTerminarTodo";
            this.btnTerminarTodo.Size = new System.Drawing.Size(232, 33);
            this.btnTerminarTodo.TabIndex = 136;
            this.btnTerminarTodo.Text = "TERMINAR";
            this.btnTerminarTodo.UseVisualStyleBackColor = true;
            this.btnTerminarTodo.Click += new System.EventHandler(this.btnTerminarTodo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(528, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 135;
            this.label11.Text = "*";
            // 
            // dgvDetalleCompras
            // 
            this.dgvDetalleCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetalleCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvDetalleCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleCompras.ColumnHeadersHeight = 30;
            this.dgvDetalleCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDetalleCompras.EnableHeadersVisualStyles = false;
            this.dgvDetalleCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgvDetalleCompras.Location = new System.Drawing.Point(642, 94);
            this.dgvDetalleCompras.MultiSelect = false;
            this.dgvDetalleCompras.Name = "dgvDetalleCompras";
            this.dgvDetalleCompras.ReadOnly = true;
            this.dgvDetalleCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalleCompras.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleCompras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompras.Size = new System.Drawing.Size(508, 293);
            this.dgvDetalleCompras.TabIndex = 142;
            // 
            // frmAgregaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1209, 477);
            this.Controls.Add(this.dgvDetalleCompras);
            this.Controls.Add(this.grupoDetalle);
            this.Controls.Add(this.txtFechaCompra);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnCompraCancelar);
            this.Controls.Add(this.btnTerminarTodo);
            this.Controls.Add(this.btnCompraAceptar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregaCompras";
            this.Text = "frmAgregaCompras";
            this.Load += new System.EventHandler(this.frmAgregaCompras_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.grupoDetalle.ResumeLayout(false);
            this.grupoDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompraCancelar;
        private System.Windows.Forms.Button btnCompraAceptar;
        private System.Windows.Forms.ComboBox txtProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtFechaCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grupoDetalle;
        private System.Windows.Forms.ComboBox txtCodCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.Button btnDetalleAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTerminarTodo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDetalleCompras;
    }
}
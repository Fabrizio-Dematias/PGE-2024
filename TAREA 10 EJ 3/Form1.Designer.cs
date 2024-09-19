namespace RegistroGastos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.dataGridGastos = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalConvertido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(25, 25);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(25, 65);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 22);
            this.txtValor.TabIndex = 1;
            // 
            // cbMoneda
            // 
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(25, 105);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(200, 24);
            this.cbMoneda.TabIndex = 2;
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.Location = new System.Drawing.Point(25, 145);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(200, 30);
            this.btnAgregarGasto.TabIndex = 3;
            this.btnAgregarGasto.Text = "Agregar Gasto";
            this.btnAgregarGasto.UseVisualStyleBackColor = true;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(25, 185);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(200, 30);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir Total";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // dataGridGastos
            // 
            this.dataGridGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Valor});
            this.dataGridGastos.Location = new System.Drawing.Point(250, 25);
            this.dataGridGastos.Name = "dataGridGastos";
            this.dataGridGastos.RowHeadersWidth = 51;
            this.dataGridGastos.RowTemplate.Height = 24;
            this.dataGridGastos.Size = new System.Drawing.Size(400, 190);
            this.dataGridGastos.TabIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // lblTotalConvertido
            // 
            this.lblTotalConvertido.AutoSize = true;
            this.lblTotalConvertido.Location = new System.Drawing.Point(250, 230);
            this.lblTotalConvertido.Name = "lblTotalConvertido";
            this.lblTotalConvertido.Size = new System.Drawing.Size(133, 17);
            this.lblTotalConvertido.TabIndex = 6;
            this.lblTotalConvertido.Text = "Total en USD: $0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 273);
            this.Controls.Add(this.lblTotalConvertido);
            this.Controls.Add(this.dataGridGastos);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnAgregarGasto);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "Form1";
            this.Text = "Registro de Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.DataGridView dataGridGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label lblTotalConvertido;
    }
}

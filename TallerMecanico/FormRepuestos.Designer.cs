namespace UIL
{
    partial class FormRepuestos
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
            this.grdRepuestos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDesperfecto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarABM = new System.Windows.Forms.Button();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuestos.Location = new System.Drawing.Point(18, 22);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.RowHeadersWidth = 40;
            this.grdRepuestos.RowTemplate.Height = 25;
            this.grdRepuestos.Size = new System.Drawing.Size(412, 213);
            this.grdRepuestos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarDesperfecto);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregarABM);
            this.groupBox1.Controls.Add(this.numPrecio);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.grdRepuestos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repuestos";
            // 
            // btnAgregarDesperfecto
            // 
            this.btnAgregarDesperfecto.Location = new System.Drawing.Point(157, 285);
            this.btnAgregarDesperfecto.Name = "btnAgregarDesperfecto";
            this.btnAgregarDesperfecto.Size = new System.Drawing.Size(135, 23);
            this.btnAgregarDesperfecto.TabIndex = 7;
            this.btnAgregarDesperfecto.Text = "Agregar al desperfecto";
            this.btnAgregarDesperfecto.UseVisualStyleBackColor = true;
            this.btnAgregarDesperfecto.Click += new System.EventHandler(this.btnAgregarDesperfecto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(224, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.brnEliminar_Click);
            // 
            // btnAgregarABM
            // 
            this.btnAgregarABM.Location = new System.Drawing.Point(143, 326);
            this.btnAgregarABM.Name = "btnAgregarABM";
            this.btnAgregarABM.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarABM.TabIndex = 5;
            this.btnAgregarABM.Text = "Agregar";
            this.btnAgregarABM.UseVisualStyleBackColor = true;
            this.btnAgregarABM.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(93, 283);
            this.numPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(73, 23);
            this.numPrecio.TabIndex = 4;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(93, 254);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(327, 23);
            this.tbDescripcion.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(47, 285);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 257);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // FormRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRepuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.FormRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdRepuestos;
        private GroupBox groupBox1;
        private NumericUpDown numPrecio;
        private TextBox tbDescripcion;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Button btnEliminar;
        private Button btnAgregarABM;
        private Button btnAgregarDesperfecto;
    }
}
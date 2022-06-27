namespace TallerMecanico
{
    partial class FormVehiculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.grdVehiculos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.numCilindrada = new System.Windows.Forms.NumericUpDown();
            this.lblTipoAuto = new System.Windows.Forms.Label();
            this.cbAutomovil = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCilindrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(115, 168);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(196, 22);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(121, 23);
            this.cbVehiculos.TabIndex = 2;
            this.cbVehiculos.SelectedValueChanged += new System.EventHandler(this.cbVehiculos_SelectedValueChanged);
            // 
            // grdVehiculos
            // 
            this.grdVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehiculos.Location = new System.Drawing.Point(60, 45);
            this.grdVehiculos.Name = "grdVehiculos";
            this.grdVehiculos.RowTemplate.Height = 25;
            this.grdVehiculos.Size = new System.Drawing.Size(504, 150);
            this.grdVehiculos.TabIndex = 3;
            this.grdVehiculos.SelectionChanged += new System.EventHandler(this.grdVehiculos_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(196, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(277, 168);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patente";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(85, 61);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(100, 23);
            this.tbPatente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(85, 90);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 23);
            this.tbMarca.TabIndex = 10;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(85, 119);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 23);
            this.tbModelo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modelo";
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(203, 65);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(61, 15);
            this.lblCilindrada.TabIndex = 13;
            this.lblCilindrada.Text = "Cilindrada";
            // 
            // numCilindrada
            // 
            this.numCilindrada.Location = new System.Drawing.Point(270, 62);
            this.numCilindrada.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCilindrada.Name = "numCilindrada";
            this.numCilindrada.Size = new System.Drawing.Size(57, 23);
            this.numCilindrada.TabIndex = 14;
            // 
            // lblTipoAuto
            // 
            this.lblTipoAuto.AutoSize = true;
            this.lblTipoAuto.Location = new System.Drawing.Point(193, 64);
            this.lblTipoAuto.Name = "lblTipoAuto";
            this.lblTipoAuto.Size = new System.Drawing.Size(103, 15);
            this.lblTipoAuto.TabIndex = 16;
            this.lblTipoAuto.Text = "Tipo de automovil";
            // 
            // cbAutomovil
            // 
            this.cbAutomovil.FormattingEnabled = true;
            this.cbAutomovil.Location = new System.Drawing.Point(302, 61);
            this.cbAutomovil.Name = "cbAutomovil";
            this.cbAutomovil.Size = new System.Drawing.Size(121, 23);
            this.cbAutomovil.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipoAuto);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.cbAutomovil);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.numCilindrada);
            this.groupBox1.Controls.Add(this.lblCilindrada);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.tbModelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbVehiculos);
            this.groupBox1.Location = new System.Drawing.Point(75, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 202);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM Vehiculos";
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdVehiculos);
            this.Name = "FormVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCilindrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnGuardar;
        private ComboBox cbVehiculos;
        private DataGridView grdVehiculos;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label1;
        private Label label2;
        private TextBox tbPatente;
        private Label label3;
        private TextBox tbMarca;
        private TextBox tbModelo;
        private Label label4;
        private Label lblCilindrada;
        private NumericUpDown numCilindrada;
        private Label lblTipoAuto;
        private ComboBox cbAutomovil;
        private GroupBox groupBox1;
    }
}
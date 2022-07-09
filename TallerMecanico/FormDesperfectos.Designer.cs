namespace UIL
{
    partial class FormDesperfectos
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
            this.grdDesperfectos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantRepuestos = new System.Windows.Forms.Label();
            this.lblManoObra = new System.Windows.Forms.Label();
            this.btnGuardarDesperfecto = new System.Windows.Forms.Button();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.grdRepuestos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarDesperfecto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesperfectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDesperfectos
            // 
            this.grdDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDesperfectos.Location = new System.Drawing.Point(22, 22);
            this.grdDesperfectos.Name = "grdDesperfectos";
            this.grdDesperfectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdDesperfectos.RowTemplate.Height = 25;
            this.grdDesperfectos.Size = new System.Drawing.Size(690, 291);
            this.grdDesperfectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mano de obra ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo (Hs.)";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(867, 50);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(259, 23);
            this.tbDescripcion.TabIndex = 4;
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(867, 78);
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(56, 23);
            this.numHoras.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de repuestos";
            // 
            // lblCantRepuestos
            // 
            this.lblCantRepuestos.AutoSize = true;
            this.lblCantRepuestos.Location = new System.Drawing.Point(867, 129);
            this.lblCantRepuestos.Name = "lblCantRepuestos";
            this.lblCantRepuestos.Size = new System.Drawing.Size(13, 15);
            this.lblCantRepuestos.TabIndex = 8;
            this.lblCantRepuestos.Text = "0";
            // 
            // lblManoObra
            // 
            this.lblManoObra.AutoSize = true;
            this.lblManoObra.Location = new System.Drawing.Point(867, 106);
            this.lblManoObra.Name = "lblManoObra";
            this.lblManoObra.Size = new System.Drawing.Size(13, 15);
            this.lblManoObra.TabIndex = 9;
            this.lblManoObra.Text = "0";
            // 
            // btnGuardarDesperfecto
            // 
            this.btnGuardarDesperfecto.Location = new System.Drawing.Point(848, 164);
            this.btnGuardarDesperfecto.Name = "btnGuardarDesperfecto";
            this.btnGuardarDesperfecto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDesperfecto.TabIndex = 10;
            this.btnGuardarDesperfecto.Text = "Guardar";
            this.btnGuardarDesperfecto.UseVisualStyleBackColor = true;
            this.btnGuardarDesperfecto.Click += new System.EventHandler(this.btnGuardarDesperfecto_Click);
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.Location = new System.Drawing.Point(460, 443);
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(114, 23);
            this.btnRepuestos.TabIndex = 11;
            this.btnRepuestos.Text = "Agregar repuestos";
            this.btnRepuestos.UseVisualStyleBackColor = true;
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuestos.Location = new System.Drawing.Point(35, 374);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.RowTemplate.Height = 25;
            this.grdRepuestos.Size = new System.Drawing.Size(377, 150);
            this.grdRepuestos.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarDesperfecto);
            this.groupBox1.Controls.Add(this.btnGuardarDesperfecto);
            this.groupBox1.Controls.Add(this.lblManoObra);
            this.groupBox1.Controls.Add(this.lblCantRepuestos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numHoras);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdDesperfectos);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 329);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desperfectos";
            // 
            // btnEliminarDesperfecto
            // 
            this.btnEliminarDesperfecto.Location = new System.Drawing.Point(929, 164);
            this.btnEliminarDesperfecto.Name = "btnEliminarDesperfecto";
            this.btnEliminarDesperfecto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDesperfecto.TabIndex = 11;
            this.btnEliminarDesperfecto.Text = "Eliminar";
            this.btnEliminarDesperfecto.UseVisualStyleBackColor = true;
            this.btnEliminarDesperfecto.Click += new System.EventHandler(this.btnEliminarDesperfecto_Click);
            // 
            // FormDesperfectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 561);
            this.Controls.Add(this.btnRepuestos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdRepuestos);
            this.Name = "FormDesperfectos";
            this.Text = "FormRepuestos";
            this.Load += new System.EventHandler(this.FormDesperfectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDesperfectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdDesperfectos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbDescripcion;
        private NumericUpDown numHoras;
        private Label label4;
        private Label lblCantRepuestos;
        private Label lblManoObra;
        private Button btnGuardarDesperfecto;
        private Button btnRepuestos;
        private DataGridView grdRepuestos;
        private GroupBox groupBox1;
        private Button btnEliminarDesperfecto;
    }
}
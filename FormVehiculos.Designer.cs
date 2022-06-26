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
            this.btnAlta = new System.Windows.Forms.Button();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.grdVehiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(437, 437);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Guardar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(142, 437);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(121, 23);
            this.cbVehiculos.TabIndex = 2;
            // 
            // grdVehiculos
            // 
            this.grdVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehiculos.Location = new System.Drawing.Point(60, 45);
            this.grdVehiculos.Name = "grdVehiculos";
            this.grdVehiculos.RowTemplate.Height = 25;
            this.grdVehiculos.Size = new System.Drawing.Size(452, 150);
            this.grdVehiculos.TabIndex = 3;
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 493);
            this.Controls.Add(this.grdVehiculos);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.btnAlta);
            this.Name = "FormVehiculos";
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAlta;
        private ComboBox cbVehiculos;
        private DataGridView grdVehiculos;
    }
}
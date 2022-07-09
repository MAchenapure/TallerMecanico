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
            this.chbCompuesto = new System.Windows.Forms.CheckBox();
            this.chbSimple = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbCompuesto
            // 
            this.chbCompuesto.AutoSize = true;
            this.chbCompuesto.Location = new System.Drawing.Point(26, 28);
            this.chbCompuesto.Name = "chbCompuesto";
            this.chbCompuesto.Size = new System.Drawing.Size(138, 19);
            this.chbCompuesto.TabIndex = 0;
            this.chbCompuesto.Text = "Repuesto compuesto";
            this.chbCompuesto.UseVisualStyleBackColor = true;
            // 
            // chbSimple
            // 
            this.chbSimple.AutoSize = true;
            this.chbSimple.Location = new System.Drawing.Point(26, 53);
            this.chbSimple.Name = "chbSimple";
            this.chbSimple.Size = new System.Drawing.Size(113, 19);
            this.chbSimple.TabIndex = 1;
            this.chbSimple.Text = "Repuesto simple";
            this.chbSimple.UseVisualStyleBackColor = true;
            // 
            // FormRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 298);
            this.Controls.Add(this.chbSimple);
            this.Controls.Add(this.chbCompuesto);
            this.Name = "FormRepuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.FormRepuestos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chbCompuesto;
        private CheckBox chbSimple;
    }
}
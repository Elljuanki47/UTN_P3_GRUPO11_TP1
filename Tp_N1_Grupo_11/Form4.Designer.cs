namespace Tp_N1_Grupo_11
{
    partial class Ejercicio3
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
            this.Estado = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(567, 82);
            this.Estado.Margin = new System.Windows.Forms.Padding(6);
            this.Estado.Name = "Estado";
            this.Estado.Padding = new System.Windows.Forms.Padding(6);
            this.Estado.Size = new System.Drawing.Size(285, 163);
            this.Estado.TabIndex = 2;
            this.Estado.TabStop = false;
            this.Estado.Text = "Estado Civil";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 741);
            this.Controls.Add(this.Estado);
            this.Name = "Ejercicio3";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Estado;
    }
}
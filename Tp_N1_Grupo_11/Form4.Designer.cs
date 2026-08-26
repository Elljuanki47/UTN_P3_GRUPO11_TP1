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
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.clbOficio = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.Estado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.Controls.Add(this.rbSoltero);
            this.Estado.Controls.Add(this.rbCasado);
            this.Estado.Location = new System.Drawing.Point(345, 44);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(121, 74);
            this.Estado.TabIndex = 2;
            this.Estado.TabStop = false;
            this.Estado.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(6, 51);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 3;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(6, 19);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 2;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Location = new System.Drawing.Point(46, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(12, 51);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(12, 19);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // clbOficio
            // 
            this.clbOficio.CheckOnClick = true;
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficio.Location = new System.Drawing.Point(164, 124);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(181, 109);
            this.clbOficio.TabIndex = 4;
            this.clbOficio.SelectedIndexChanged += new System.EventHandler(this.clbOficio_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(164, 252);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(181, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar lo que se selecciono";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 401);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.clbOficio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Estado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ejercicio3";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Estado;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.Button btnMostrar;
    }
}
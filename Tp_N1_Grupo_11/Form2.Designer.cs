namespace Tp_N1_Grupo_11
{
    partial class Ejercicio1
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
            this.lblIngrese = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.ListBox();
            this.btnMoverUno = new System.Windows.Forms.Button();
            this.lstSeleccionados = new System.Windows.Forms.ListBox();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(110, 57);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(165, 20);
            this.lblIngrese.TabIndex = 0;
            this.lblIngrese.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(281, 57);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(542, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 34);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.Location = new System.Drawing.Point(113, 101);
            this.Box1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(208, 277);
            this.Box1.TabIndex = 3;
            // 
            // btnMoverUno
            // 
            this.btnMoverUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverUno.Location = new System.Drawing.Point(385, 135);
            this.btnMoverUno.Name = "btnMoverUno";
            this.btnMoverUno.Size = new System.Drawing.Size(57, 55);
            this.btnMoverUno.TabIndex = 4;
            this.btnMoverUno.Text = ">";
            this.btnMoverUno.UseVisualStyleBackColor = true;
            this.btnMoverUno.Click += new System.EventHandler(this.btnMoverUno_Click);
            // 
            // lstSeleccionados
            // 
            this.lstSeleccionados.FormattingEnabled = true;
            this.lstSeleccionados.Location = new System.Drawing.Point(493, 101);
            this.lstSeleccionados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstSeleccionados.Name = "lstSeleccionados";
            this.lstSeleccionados.Size = new System.Drawing.Size(208, 277);
            this.lstSeleccionados.TabIndex = 5;
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.AutoSize = true;
            this.btnMoverTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverTodos.Location = new System.Drawing.Point(385, 224);
            this.btnMoverTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(57, 55);
            this.btnMoverTodos.TabIndex = 6;
            this.btnMoverTodos.Text = ">>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.lstSeleccionados);
            this.Controls.Add(this.btnMoverUno);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngrese);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox Box1;
        private System.Windows.Forms.Button btnMoverUno;
        private System.Windows.Forms.ListBox lstSeleccionados;
        private System.Windows.Forms.Button btnMoverTodos;
    }
}
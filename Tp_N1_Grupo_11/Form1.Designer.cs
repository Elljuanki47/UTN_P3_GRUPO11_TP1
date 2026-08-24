namespace Tp_N1_Grupo_11
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblIntegrante1 = new System.Windows.Forms.Label();
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.lblIntegrante2 = new System.Windows.Forms.Label();
            this.lblIntegrante3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(33, 160);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(115, 25);
            this.lblIntegrantes.TabIndex = 0;
            this.lblIntegrantes.Text = "Integrantes:";
            // 
            // lblIntegrante1
            // 
            this.lblIntegrante1.AutoSize = true;
            this.lblIntegrante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante1.Location = new System.Drawing.Point(146, 205);
            this.lblIntegrante1.Name = "lblIntegrante1";
            this.lblIntegrante1.Size = new System.Drawing.Size(151, 20);
            this.lblIntegrante1.TabIndex = 1;
            this.lblIntegrante1.Text = "Zárate Juan Ingacio";
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.Location = new System.Drawing.Point(64, 56);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(138, 58);
            this.btnEjercicio1.TabIndex = 2;
            this.btnEjercicio1.Text = "EJERCICIO 1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // lblIntegrante2
            // 
            this.lblIntegrante2.AutoSize = true;
            this.lblIntegrante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante2.Location = new System.Drawing.Point(146, 239);
            this.lblIntegrante2.Name = "lblIntegrante2";
            this.lblIntegrante2.Size = new System.Drawing.Size(214, 20);
            this.lblIntegrante2.TabIndex = 3;
            this.lblIntegrante2.Text = "Deledicque Joaquin Ezequiel";
            // 
            // lblIntegrante3
            // 
            this.lblIntegrante3.AutoSize = true;
            this.lblIntegrante3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIntegrante3.Location = new System.Drawing.Point(146, 274);
            this.lblIntegrante3.Name = "lblIntegrante3";
            this.lblIntegrante3.Size = new System.Drawing.Size(199, 20);
            this.lblIntegrante3.TabIndex = 3;
            this.lblIntegrante3.Text = "Mendez Ezequiel Santiago";
            this.lblIntegrante3.Click += new System.EventHandler(this.lblIntegrante3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(146, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marchetti Miño Santiago Ezequiel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(146, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gallo Martin Felipe";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIntegrante3);
            this.Controls.Add(this.lblIntegrante2);
            this.Controls.Add(this.btnEjercicio1);
            this.Controls.Add(this.lblIntegrante1);
            this.Controls.Add(this.lblIntegrantes);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblIntegrante1;
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Label lblIntegrante2;
        private System.Windows.Forms.Label lblIntegrante3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


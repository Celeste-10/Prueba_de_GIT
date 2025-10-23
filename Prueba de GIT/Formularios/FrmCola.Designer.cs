namespace Prueba_de_GIT.Formularios
{
    partial class FrmCola
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbElemento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblElemento = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrimerElemento = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento:";
            // 
            // tbElemento
            // 
            this.tbElemento.Location = new System.Drawing.Point(131, 52);
            this.tbElemento.Name = "tbElemento";
            this.tbElemento.Size = new System.Drawing.Size(275, 22);
            this.tbElemento.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(452, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 55);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblElemento
            // 
            this.lblElemento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElemento.Location = new System.Drawing.Point(34, 118);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(568, 86);
            this.lblElemento.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 114);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPrimerElemento
            // 
            this.btnPrimerElemento.Location = new System.Drawing.Point(250, 283);
            this.btnPrimerElemento.Name = "btnPrimerElemento";
            this.btnPrimerElemento.Size = new System.Drawing.Size(200, 114);
            this.btnPrimerElemento.TabIndex = 5;
            this.btnPrimerElemento.Text = "Primer elemento";
            this.btnPrimerElemento.UseVisualStyleBackColor = true;
            this.btnPrimerElemento.Click += new System.EventHandler(this.btnPrimerElemento_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(471, 283);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(200, 114);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Cantidad de Elementos\r\n";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(250, 449);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(200, 114);
            this.btnVaciar.TabIndex = 7;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 607);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPrimerElemento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbElemento);
            this.Controls.Add(this.label1);
            this.Name = "FrmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCola";
            this.Load += new System.EventHandler(this.FrmCola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrimerElemento;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnVaciar;
    }
}
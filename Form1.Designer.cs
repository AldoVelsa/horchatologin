﻿namespace HorchatoLogin
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avisos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txbxusuario = new System.Windows.Forms.TextBox();
            this.txbxcontra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNI SUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // avisos
            // 
            this.avisos.AutoSize = true;
            this.avisos.Location = new System.Drawing.Point(101, 272);
            this.avisos.Name = "avisos";
            this.avisos.Size = new System.Drawing.Size(13, 13);
            this.avisos.TabIndex = 4;
            this.avisos.Text = "--";
            this.avisos.Click += new System.EventHandler(this.avisos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(593, 292);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txbxusuario
            // 
            this.txbxusuario.Location = new System.Drawing.Point(441, 137);
            this.txbxusuario.Name = "txbxusuario";
            this.txbxusuario.Size = new System.Drawing.Size(100, 20);
            this.txbxusuario.TabIndex = 7;
            // 
            // txbxcontra
            // 
            this.txbxcontra.Location = new System.Drawing.Point(441, 215);
            this.txbxcontra.Name = "txbxcontra";
            this.txbxcontra.Size = new System.Drawing.Size(100, 20);
            this.txbxcontra.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbxcontra);
            this.Controls.Add(this.txbxusuario);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avisos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Horchato Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avisos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txbxusuario;
        private System.Windows.Forms.TextBox txbxcontra;
    }
}


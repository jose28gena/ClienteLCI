﻿namespace Cliente_LCI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerServidor = new System.Windows.Forms.Timer(this.components);
            this.timerCliente = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonCIP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCNombre = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerServidor
            // 
            this.timerServidor.Tick += new System.EventHandler(this.timerServidor_Tick);
            // 
            // timerCliente
            // 
            this.timerCliente.Tick += new System.EventHandler(this.timerCliente_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mensaje 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonCIP
            // 
            this.botonCIP.Location = new System.Drawing.Point(175, 291);
            this.botonCIP.Name = "botonCIP";
            this.botonCIP.Size = new System.Drawing.Size(97, 23);
            this.botonCIP.TabIndex = 2;
            this.botonCIP.Text = "Cambiar IP";
            this.botonCIP.UseVisualStyleBackColor = true;
            this.botonCIP.Click += new System.EventHandler(this.botonCIP_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(428, 176);
            this.textBox1.TabIndex = 3;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(344, 291);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(97, 23);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "...";
            // 
            // botonCNombre
            // 
            this.botonCNombre.Location = new System.Drawing.Point(15, 291);
            this.botonCNombre.Name = "botonCNombre";
            this.botonCNombre.Size = new System.Drawing.Size(94, 23);
            this.botonCNombre.TabIndex = 6;
            this.botonCNombre.Text = "Cambiar nombre";
            this.botonCNombre.UseVisualStyleBackColor = true;
            this.botonCNombre.Click += new System.EventHandler(this.botonCNombre_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mensaje 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mensaje 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonCNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonCIP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cliente LCI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerServidor;
        private System.Windows.Forms.Timer timerCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonCIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


namespace Ejercicio7
{
    partial class Form1
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
            this.i = new System.Windows.Forms.Label();
            this.Temperatura1 = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfarenhit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Location = new System.Drawing.Point(12, 27);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(150, 13);
            this.i.TabIndex = 0;
            this.i.Text = "ingresa los grados centigrados";
            this.i.Click += new System.EventHandler(this.label1_Click);
            // 
            // Temperatura1
            // 
            this.Temperatura1.Location = new System.Drawing.Point(173, 24);
            this.Temperatura1.Name = "Temperatura1";
            this.Temperatura1.Size = new System.Drawing.Size(100, 20);
            this.Temperatura1.TabIndex = 1;
            this.Temperatura1.Text = "0.00";
            this.Temperatura1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Temperatura1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Temperatura1_KeyPress);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(110, 178);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(148, 23);
            this.btnconvertir.TabIndex = 8;
            this.btnconvertir.Text = "Aceptar";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btnfarenhit
            // 
            this.btnfarenhit.Location = new System.Drawing.Point(173, 88);
            this.btnfarenhit.Name = "btnfarenhit";
            this.btnfarenhit.Size = new System.Drawing.Size(100, 20);
            this.btnfarenhit.TabIndex = 2;
            this.btnfarenhit.Text = "32";
            this.btnfarenhit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnfarenhit_KeyPress);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnconvertir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 314);
            this.Controls.Add(this.btnfarenhit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.Temperatura1);
            this.Controls.Add(this.i);
            this.Name = "Form1";
            this.Text = "Coversion de temperaturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label i;
        private System.Windows.Forms.TextBox Temperatura1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btnfarenhit;
    }
}


namespace POO_Problema_4
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Varreglo = new System.Windows.Forms.Label();
            this.txt_ParesNeg = new System.Windows.Forms.TextBox();
            this.txt_arreglo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_ = new System.Windows.Forms.TextBox();
            this.txt_PorcentajeCeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(213, 305);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // lbl_Varreglo
            // 
            this.lbl_Varreglo.AutoSize = true;
            this.lbl_Varreglo.Location = new System.Drawing.Point(12, 32);
            this.lbl_Varreglo.Name = "lbl_Varreglo";
            this.lbl_Varreglo.Size = new System.Drawing.Size(125, 13);
            this.lbl_Varreglo.TabIndex = 1;
            this.lbl_Varreglo.Text = "Ingrese el valor al arreglo";
            this.lbl_Varreglo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ParesNeg
            // 
            this.txt_ParesNeg.Location = new System.Drawing.Point(392, 134);
            this.txt_ParesNeg.Name = "txt_ParesNeg";
            this.txt_ParesNeg.ReadOnly = true;
            this.txt_ParesNeg.Size = new System.Drawing.Size(100, 20);
            this.txt_ParesNeg.TabIndex = 2;
            // 
            // txt_arreglo
            // 
            this.txt_arreglo.Location = new System.Drawing.Point(143, 32);
            this.txt_arreglo.Name = "txt_arreglo";
            this.txt_arreglo.Size = new System.Drawing.Size(100, 20);
            this.txt_arreglo.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(392, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // txt_
            // 
            this.txt_.Location = new System.Drawing.Point(392, 188);
            this.txt_.Name = "txt_";
            this.txt_.ReadOnly = true;
            this.txt_.Size = new System.Drawing.Size(100, 20);
            this.txt_.TabIndex = 6;
            // 
            // txt_PorcentajeCeros
            // 
            this.txt_PorcentajeCeros.Location = new System.Drawing.Point(392, 162);
            this.txt_PorcentajeCeros.Name = "txt_PorcentajeCeros";
            this.txt_PorcentajeCeros.ReadOnly = true;
            this.txt_PorcentajeCeros.Size = new System.Drawing.Size(100, 20);
            this.txt_PorcentajeCeros.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "OPERACIONES CON ARREGLOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero mayor de pares negativos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Porcentaje de ceros en el arreglo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Promedio de impares positivos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mayor de los pares positivos";
            // 
            // lst_lista
            // 
            this.lst_lista.FormattingEnabled = true;
            this.lst_lista.Location = new System.Drawing.Point(32, 99);
            this.lst_lista.Name = "lst_lista";
            this.lst_lista.Size = new System.Drawing.Size(124, 199);
            this.lst_lista.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 355);
            this.Controls.Add(this.lst_lista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PorcentajeCeros);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_arreglo);
            this.Controls.Add(this.txt_ParesNeg);
            this.Controls.Add(this.lbl_Varreglo);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Varreglo;
        private System.Windows.Forms.TextBox txt_ParesNeg;
        private System.Windows.Forms.TextBox txt_arreglo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_;
        private System.Windows.Forms.TextBox txt_PorcentajeCeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_lista;
    }
}


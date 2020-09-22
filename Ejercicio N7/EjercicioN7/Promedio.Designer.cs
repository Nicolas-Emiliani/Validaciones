namespace EjercicioN7
{
    partial class Promedio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromGral = new System.Windows.Forms.TextBox();
            this.lstAlumno = new System.Windows.Forms.ListBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lstLegajo = new System.Windows.Forms.ListBox();
            this.lstNota1 = new System.Windows.Forms.ListBox();
            this.lstNota2 = new System.Windows.Forms.ListBox();
            this.lstNota3 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lstProm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 3";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(91, 138);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 2;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(91, 165);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 3;
            this.txtNota2.TextChanged += new System.EventHandler(this.txtNota2_TextChanged);
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(91, 192);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 4;
            this.txtNota3.TextChanged += new System.EventHandler(this.txtNota3_TextChanged);
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(87, 225);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(111, 37);
            this.btnPromedio.TabIndex = 5;
            this.btnPromedio.Text = "Calcular";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Legajo";
            // 
            // txtPromGral
            // 
            this.txtPromGral.Location = new System.Drawing.Point(678, 235);
            this.txtPromGral.Name = "txtPromGral";
            this.txtPromGral.Size = new System.Drawing.Size(124, 20);
            this.txtPromGral.TabIndex = 11;
            // 
            // lstAlumno
            // 
            this.lstAlumno.FormattingEnabled = true;
            this.lstAlumno.Location = new System.Drawing.Point(231, 48);
            this.lstAlumno.Name = "lstAlumno";
            this.lstAlumno.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAlumno.Size = new System.Drawing.Size(142, 173);
            this.lstAlumno.TabIndex = 12;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(91, 45);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno.TabIndex = 0;
            this.txtAlumno.TextChanged += new System.EventHandler(this.txtAlumno_TextChanged);
            this.txtAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlumno_KeyPress);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(91, 78);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // lstLegajo
            // 
            this.lstLegajo.FormattingEnabled = true;
            this.lstLegajo.Location = new System.Drawing.Point(392, 48);
            this.lstLegajo.Name = "lstLegajo";
            this.lstLegajo.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLegajo.Size = new System.Drawing.Size(146, 173);
            this.lstLegajo.TabIndex = 16;
            // 
            // lstNota1
            // 
            this.lstNota1.FormattingEnabled = true;
            this.lstNota1.Location = new System.Drawing.Point(563, 48);
            this.lstNota1.Name = "lstNota1";
            this.lstNota1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNota1.Size = new System.Drawing.Size(59, 173);
            this.lstNota1.TabIndex = 17;
            // 
            // lstNota2
            // 
            this.lstNota2.FormattingEnabled = true;
            this.lstNota2.Location = new System.Drawing.Point(628, 48);
            this.lstNota2.Name = "lstNota2";
            this.lstNota2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNota2.Size = new System.Drawing.Size(59, 173);
            this.lstNota2.TabIndex = 18;
            // 
            // lstNota3
            // 
            this.lstNota3.FormattingEnabled = true;
            this.lstNota3.Location = new System.Drawing.Point(693, 48);
            this.lstNota3.Name = "lstNota3";
            this.lstNota3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNota3.Size = new System.Drawing.Size(59, 173);
            this.lstNota3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Promedio General";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Alumno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Legajo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(573, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nota 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(637, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nota 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(701, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nota 3";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(771, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(90, 268);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(781, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Promedio";
            // 
            // lstProm
            // 
            this.lstProm.FormattingEnabled = true;
            this.lstProm.Location = new System.Drawing.Point(777, 48);
            this.lstProm.Name = "lstProm";
            this.lstProm.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstProm.Size = new System.Drawing.Size(59, 173);
            this.lstProm.TabIndex = 28;
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 308);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstProm);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstNota3);
            this.Controls.Add(this.lstNota2);
            this.Controls.Add(this.lstNota1);
            this.Controls.Add(this.lstLegajo);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lstAlumno);
            this.Controls.Add(this.txtPromGral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Promedio";
            this.Text = "Promedios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Promedio_FormClosing);
            this.Load += new System.EventHandler(this.Promedio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromGral;
        private System.Windows.Forms.ListBox lstAlumno;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ListBox lstLegajo;
        private System.Windows.Forms.ListBox lstNota1;
        private System.Windows.Forms.ListBox lstNota2;
        private System.Windows.Forms.ListBox lstNota3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstProm;
    }
}


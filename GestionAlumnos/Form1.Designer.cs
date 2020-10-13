namespace GestionAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cNombre = new System.Windows.Forms.TextBox();
            this.cApellidos = new System.Windows.Forms.TextBox();
            this.cFechaNacimineto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cListaAlumnos = new System.Windows.Forms.RichTextBox();
            this.cGrupo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // cNombre
            // 
            this.cNombre.Location = new System.Drawing.Point(243, 37);
            this.cNombre.Name = "cNombre";
            this.cNombre.Size = new System.Drawing.Size(284, 20);
            this.cNombre.TabIndex = 3;
            this.cNombre.Text = "Maria";
            // 
            // cApellidos
            // 
            this.cApellidos.Location = new System.Drawing.Point(243, 93);
            this.cApellidos.Name = "cApellidos";
            this.cApellidos.Size = new System.Drawing.Size(284, 20);
            this.cApellidos.TabIndex = 4;
            this.cApellidos.Text = "Vevel";
            // 
            // cFechaNacimineto
            // 
            this.cFechaNacimineto.Location = new System.Drawing.Point(243, 144);
            this.cFechaNacimineto.Name = "cFechaNacimineto";
            this.cFechaNacimineto.Size = new System.Drawing.Size(284, 20);
            this.cFechaNacimineto.TabIndex = 5;
            this.cFechaNacimineto.Text = "28031989";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grupo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Alta alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cListaAlumnos
            // 
            this.cListaAlumnos.Location = new System.Drawing.Point(88, 241);
            this.cListaAlumnos.Name = "cListaAlumnos";
            this.cListaAlumnos.Size = new System.Drawing.Size(439, 96);
            this.cListaAlumnos.TabIndex = 11;
            this.cListaAlumnos.Text = "";
            // 
            // cGrupo
            // 
            this.cGrupo.FormattingEnabled = true;
            this.cGrupo.Location = new System.Drawing.Point(243, 198);
            this.cGrupo.Name = "cGrupo";
            this.cGrupo.Size = new System.Drawing.Size(284, 21);
            this.cGrupo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 426);
            this.Controls.Add(this.cGrupo);
            this.Controls.Add(this.cListaAlumnos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cFechaNacimineto);
            this.Controls.Add(this.cApellidos);
            this.Controls.Add(this.cNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cNombre;
        private System.Windows.Forms.TextBox cApellidos;
        private System.Windows.Forms.TextBox cFechaNacimineto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox cListaAlumnos;
        private System.Windows.Forms.ComboBox cGrupo;
    }
}


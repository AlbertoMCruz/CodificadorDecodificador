namespace CodDecod
{
    partial class CodificarDecodificar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.codascii = new System.Windows.Forms.Button();
            this.decodascii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.decodmor = new System.Windows.Forms.Button();
            this.codmor = new System.Windows.Forms.Button();
            this.decodce = new System.Windows.Forms.Button();
            this.codce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decodes = new System.Windows.Forms.Button();
            this.codes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codificación ASCII";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // codascii
            // 
            this.codascii.Location = new System.Drawing.Point(58, 48);
            this.codascii.Name = "codascii";
            this.codascii.Size = new System.Drawing.Size(75, 23);
            this.codascii.TabIndex = 1;
            this.codascii.Text = "Codificar";
            this.codascii.UseVisualStyleBackColor = true;
            this.codascii.Click += new System.EventHandler(this.codascii_Click);
            // 
            // decodascii
            // 
            this.decodascii.Location = new System.Drawing.Point(179, 48);
            this.decodascii.Name = "decodascii";
            this.decodascii.Size = new System.Drawing.Size(75, 23);
            this.decodascii.TabIndex = 2;
            this.decodascii.Text = "Decodificar";
            this.decodascii.UseVisualStyleBackColor = true;
            this.decodascii.Click += new System.EventHandler(this.decodascii_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codificación Morse";
            // 
            // decodmor
            // 
            this.decodmor.Location = new System.Drawing.Point(179, 140);
            this.decodmor.Name = "decodmor";
            this.decodmor.Size = new System.Drawing.Size(75, 23);
            this.decodmor.TabIndex = 5;
            this.decodmor.Text = "Decodificar";
            this.decodmor.UseVisualStyleBackColor = true;
            this.decodmor.Click += new System.EventHandler(this.decodmor_Click);
            // 
            // codmor
            // 
            this.codmor.Location = new System.Drawing.Point(58, 140);
            this.codmor.Name = "codmor";
            this.codmor.Size = new System.Drawing.Size(75, 23);
            this.codmor.TabIndex = 4;
            this.codmor.Text = "Codificar";
            this.codmor.UseVisualStyleBackColor = true;
            this.codmor.Click += new System.EventHandler(this.codmor_Click);
            // 
            // decodce
            // 
            this.decodce.Location = new System.Drawing.Point(179, 239);
            this.decodce.Name = "decodce";
            this.decodce.Size = new System.Drawing.Size(75, 23);
            this.decodce.TabIndex = 8;
            this.decodce.Text = "Decodificar";
            this.decodce.UseVisualStyleBackColor = true;
            this.decodce.Click += new System.EventHandler(this.decodce_Click);
            // 
            // codce
            // 
            this.codce.Location = new System.Drawing.Point(58, 239);
            this.codce.Name = "codce";
            this.codce.Size = new System.Drawing.Size(75, 23);
            this.codce.TabIndex = 7;
            this.codce.Text = "Codificar";
            this.codce.UseVisualStyleBackColor = true;
            this.codce.Click += new System.EventHandler(this.codce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codificación César";
            // 
            // decodes
            // 
            this.decodes.Location = new System.Drawing.Point(179, 342);
            this.decodes.Name = "decodes";
            this.decodes.Size = new System.Drawing.Size(75, 23);
            this.decodes.TabIndex = 11;
            this.decodes.Text = "Decodificar";
            this.decodes.UseVisualStyleBackColor = true;
            this.decodes.Click += new System.EventHandler(this.button1_Click);
            // 
            // codes
            // 
            this.codes.Location = new System.Drawing.Point(58, 342);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(75, 23);
            this.codes.TabIndex = 10;
            this.codes.Text = "Codificar";
            this.codes.UseVisualStyleBackColor = true;
            this.codes.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codificación Escítala";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(12, 405);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(56, 23);
            this.salir.TabIndex = 12;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // open
            // 
            this.open.DefaultExt = "txt";
            this.open.Filter = "Archivos de Texto (*.txt)|*.txt";
            // 
            // save
            // 
            this.save.DefaultExt = "Archivo de texto (*.txt)|*.txt";
            this.save.FileName = "DecodeASCII";
            this.save.Filter = "Archivo de texto (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 440);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.decodes);
            this.Controls.Add(this.codes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decodce);
            this.Controls.Add(this.codce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decodmor);
            this.Controls.Add(this.codmor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decodascii);
            this.Controls.Add(this.codascii);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Codificadores - Decodificadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button codascii;
        private System.Windows.Forms.Button decodascii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decodmor;
        private System.Windows.Forms.Button codmor;
        private System.Windows.Forms.Button decodce;
        private System.Windows.Forms.Button codce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decodes;
        private System.Windows.Forms.Button codes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.SaveFileDialog save;
    }
}


namespace Tarea1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotonSalir = new System.Windows.Forms.Button();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.CesarBoton = new System.Windows.Forms.Button();
            this.LlaveBoton = new System.Windows.Forms.Button();
            this.InversaBoton = new System.Windows.Forms.Button();
            this.PalabraInvBoton = new System.Windows.Forms.Button();
            this.TelefonicoBoton = new System.Windows.Forms.Button();
            this.VigenereBoton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonSalir
            // 
            this.BotonSalir.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalir.ForeColor = System.Drawing.Color.Crimson;
            this.BotonSalir.Location = new System.Drawing.Point(307, 326);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(75, 23);
            this.BotonSalir.TabIndex = 1;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.LabelTitulo.Location = new System.Drawing.Point(70, 65);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(246, 21);
            this.LabelTitulo.TabIndex = 2;
            this.LabelTitulo.Text = "Tarea 1 - Steven Vega Zúñiga";
            this.LabelTitulo.Click += new System.EventHandler(this.LabelTitulo_Click);
            // 
            // CesarBoton
            // 
            this.CesarBoton.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CesarBoton.Location = new System.Drawing.Point(28, 146);
            this.CesarBoton.Name = "CesarBoton";
            this.CesarBoton.Size = new System.Drawing.Size(75, 23);
            this.CesarBoton.TabIndex = 4;
            this.CesarBoton.Text = "Cesar";
            this.CesarBoton.UseVisualStyleBackColor = true;
            this.CesarBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LlaveBoton
            // 
            this.LlaveBoton.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlaveBoton.Location = new System.Drawing.Point(158, 146);
            this.LlaveBoton.Name = "LlaveBoton";
            this.LlaveBoton.Size = new System.Drawing.Size(75, 23);
            this.LlaveBoton.TabIndex = 5;
            this.LlaveBoton.Text = "Por Llave";
            this.LlaveBoton.UseVisualStyleBackColor = true;
            // 
            // InversaBoton
            // 
            this.InversaBoton.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InversaBoton.Location = new System.Drawing.Point(28, 212);
            this.InversaBoton.Name = "InversaBoton";
            this.InversaBoton.Size = new System.Drawing.Size(75, 23);
            this.InversaBoton.TabIndex = 6;
            this.InversaBoton.Text = "Inversa";
            this.InversaBoton.UseVisualStyleBackColor = true;
            // 
            // PalabraInvBoton
            // 
            this.PalabraInvBoton.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalabraInvBoton.Location = new System.Drawing.Point(158, 212);
            this.PalabraInvBoton.Name = "PalabraInvBoton";
            this.PalabraInvBoton.Size = new System.Drawing.Size(75, 23);
            this.PalabraInvBoton.TabIndex = 7;
            this.PalabraInvBoton.Text = "PalabraInv";
            this.PalabraInvBoton.UseVisualStyleBackColor = true;
            // 
            // TelefonicoBoton
            // 
            this.TelefonicoBoton.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonicoBoton.Location = new System.Drawing.Point(279, 212);
            this.TelefonicoBoton.Name = "TelefonicoBoton";
            this.TelefonicoBoton.Size = new System.Drawing.Size(75, 23);
            this.TelefonicoBoton.TabIndex = 8;
            this.TelefonicoBoton.Text = "Telefonico";
            this.TelefonicoBoton.UseVisualStyleBackColor = true;
            // 
            // VigenereBoton
            // 
            this.VigenereBoton.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VigenereBoton.Location = new System.Drawing.Point(279, 146);
            this.VigenereBoton.Name = "VigenereBoton";
            this.VigenereBoton.Size = new System.Drawing.Size(75, 23);
            this.VigenereBoton.TabIndex = 9;
            this.VigenereBoton.Text = "Vigenere";
            this.VigenereBoton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Binario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(158, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Bin2Asc";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea1.Properties.Resources._748646;
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(279, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "TelAText";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VigenereBoton);
            this.Controls.Add(this.TelefonicoBoton);
            this.Controls.Add(this.PalabraInvBoton);
            this.Controls.Add(this.InversaBoton);
            this.Controls.Add(this.LlaveBoton);
            this.Controls.Add(this.CesarBoton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.BotonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tarea1 - SVZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CesarBoton;
        private System.Windows.Forms.Button LlaveBoton;
        private System.Windows.Forms.Button InversaBoton;
        private System.Windows.Forms.Button PalabraInvBoton;
        private System.Windows.Forms.Button TelefonicoBoton;
        private System.Windows.Forms.Button VigenereBoton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


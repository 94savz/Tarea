namespace Tarea1
{
    partial class Inversa
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
            this.TBResInv = new System.Windows.Forms.TextBox();
            this.CifrarInv = new System.Windows.Forms.Button();
            this.DescifrarInv = new System.Windows.Forms.Button();
            this.TextInv = new System.Windows.Forms.Label();
            this.ResultadoInv = new System.Windows.Forms.Label();
            this.TBInv = new System.Windows.Forms.TextBox();
            this.VolverInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBResInv
            // 
            this.TBResInv.Location = new System.Drawing.Point(12, 244);
            this.TBResInv.Name = "TBResInv";
            this.TBResInv.Size = new System.Drawing.Size(310, 20);
            this.TBResInv.TabIndex = 12;
            // 
            // CifrarInv
            // 
            this.CifrarInv.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CifrarInv.Location = new System.Drawing.Point(33, 123);
            this.CifrarInv.Name = "CifrarInv";
            this.CifrarInv.Size = new System.Drawing.Size(75, 23);
            this.CifrarInv.TabIndex = 11;
            this.CifrarInv.Text = "Cifrar";
            this.CifrarInv.UseVisualStyleBackColor = true;
            // 
            // DescifrarInv
            // 
            this.DescifrarInv.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescifrarInv.Location = new System.Drawing.Point(226, 123);
            this.DescifrarInv.Name = "DescifrarInv";
            this.DescifrarInv.Size = new System.Drawing.Size(75, 23);
            this.DescifrarInv.TabIndex = 10;
            this.DescifrarInv.Text = "Descifrar";
            this.DescifrarInv.UseVisualStyleBackColor = true;
            // 
            // TextInv
            // 
            this.TextInv.AutoSize = true;
            this.TextInv.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInv.Location = new System.Drawing.Point(129, 46);
            this.TextInv.Name = "TextInv";
            this.TextInv.Size = new System.Drawing.Size(94, 17);
            this.TextInv.TabIndex = 9;
            this.TextInv.Text = "Digite el texto";
            // 
            // ResultadoInv
            // 
            this.ResultadoInv.AutoSize = true;
            this.ResultadoInv.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoInv.Location = new System.Drawing.Point(145, 216);
            this.ResultadoInv.Name = "ResultadoInv";
            this.ResultadoInv.Size = new System.Drawing.Size(68, 17);
            this.ResultadoInv.TabIndex = 8;
            this.ResultadoInv.Text = "Resultado";
            // 
            // TBInv
            // 
            this.TBInv.Location = new System.Drawing.Point(12, 80);
            this.TBInv.Name = "TBInv";
            this.TBInv.Size = new System.Drawing.Size(310, 20);
            this.TBInv.TabIndex = 7;
            // 
            // VolverInv
            // 
            this.VolverInv.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverInv.Location = new System.Drawing.Point(260, 287);
            this.VolverInv.Name = "VolverInv";
            this.VolverInv.Size = new System.Drawing.Size(75, 23);
            this.VolverInv.TabIndex = 15;
            this.VolverInv.Text = "Volver";
            this.VolverInv.UseVisualStyleBackColor = true;
            // 
            // Inversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.VolverInv);
            this.Controls.Add(this.TBResInv);
            this.Controls.Add(this.CifrarInv);
            this.Controls.Add(this.DescifrarInv);
            this.Controls.Add(this.TextInv);
            this.Controls.Add(this.ResultadoInv);
            this.Controls.Add(this.TBInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inversa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inversa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBResInv;
        private System.Windows.Forms.Button CifrarInv;
        private System.Windows.Forms.Button DescifrarInv;
        private System.Windows.Forms.Label TextInv;
        private System.Windows.Forms.Label ResultadoInv;
        private System.Windows.Forms.TextBox TBInv;
        private System.Windows.Forms.Button VolverInv;
    }
}
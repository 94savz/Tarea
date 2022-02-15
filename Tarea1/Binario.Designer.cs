namespace Tarea1
{
    partial class Binario
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VolverVig = new System.Windows.Forms.Button();
            this.TextVG = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(310, 20);
            this.textBox4.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Binario";
            // 
            // VolverVig
            // 
            this.VolverVig.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverVig.Location = new System.Drawing.Point(253, 269);
            this.VolverVig.Name = "VolverVig";
            this.VolverVig.Size = new System.Drawing.Size(75, 23);
            this.VolverVig.TabIndex = 24;
            this.VolverVig.Text = "Volver";
            this.VolverVig.UseVisualStyleBackColor = true;
            // 
            // TextVG
            // 
            this.TextVG.AutoSize = true;
            this.TextVG.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVG.Location = new System.Drawing.Point(137, 138);
            this.TextVG.Name = "TextVG";
            this.TextVG.Size = new System.Drawing.Size(68, 17);
            this.TextVG.TabIndex = 22;
            this.TextVG.Text = "Resultado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Binario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VolverVig);
            this.Controls.Add(this.TextVG);
            this.Controls.Add(this.textBox2);
            this.MinimizeBox = false;
            this.Name = "Binario";
            this.Text = "Bin2Asc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VolverVig;
        private System.Windows.Forms.Label TextVG;
        private System.Windows.Forms.TextBox textBox2;
    }
}
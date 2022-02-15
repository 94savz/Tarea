namespace Tarea1
{
    partial class Cesar
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
            this.InputTextCesar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DigiteTextoCs = new System.Windows.Forms.Label();
            this.DescifrarCS = new System.Windows.Forms.Button();
            this.CifrarCS = new System.Windows.Forms.Button();
            this.ResultCS = new System.Windows.Forms.Label();
            this.VolverCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTextCesar
            // 
            this.InputTextCesar.Location = new System.Drawing.Point(17, 76);
            this.InputTextCesar.Name = "InputTextCesar";
            this.InputTextCesar.Size = new System.Drawing.Size(305, 22);
            this.InputTextCesar.TabIndex = 0;
            this.InputTextCesar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cifrado Cesar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 22);
            this.textBox1.TabIndex = 2;
            // 
            // DigiteTextoCs
            // 
            this.DigiteTextoCs.AutoSize = true;
            this.DigiteTextoCs.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiteTextoCs.ForeColor = System.Drawing.Color.Transparent;
            this.DigiteTextoCs.Location = new System.Drawing.Point(119, 55);
            this.DigiteTextoCs.Name = "DigiteTextoCs";
            this.DigiteTextoCs.Size = new System.Drawing.Size(98, 18);
            this.DigiteTextoCs.TabIndex = 3;
            this.DigiteTextoCs.Text = "Digite el texto";
            // 
            // DescifrarCS
            // 
            this.DescifrarCS.Location = new System.Drawing.Point(221, 104);
            this.DescifrarCS.Name = "DescifrarCS";
            this.DescifrarCS.Size = new System.Drawing.Size(75, 23);
            this.DescifrarCS.TabIndex = 4;
            this.DescifrarCS.Text = "Descifrar";
            this.DescifrarCS.UseVisualStyleBackColor = true;
            // 
            // CifrarCS
            // 
            this.CifrarCS.Location = new System.Drawing.Point(47, 104);
            this.CifrarCS.Name = "CifrarCS";
            this.CifrarCS.Size = new System.Drawing.Size(75, 23);
            this.CifrarCS.TabIndex = 5;
            this.CifrarCS.Text = "Cifrar";
            this.CifrarCS.UseVisualStyleBackColor = true;
            this.CifrarCS.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultCS
            // 
            this.ResultCS.AutoSize = true;
            this.ResultCS.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultCS.ForeColor = System.Drawing.Color.Transparent;
            this.ResultCS.Location = new System.Drawing.Point(133, 159);
            this.ResultCS.Name = "ResultCS";
            this.ResultCS.Size = new System.Drawing.Size(73, 18);
            this.ResultCS.TabIndex = 6;
            this.ResultCS.Text = "Resultado";
            // 
            // VolverCS
            // 
            this.VolverCS.Location = new System.Drawing.Point(258, 287);
            this.VolverCS.Name = "VolverCS";
            this.VolverCS.Size = new System.Drawing.Size(75, 23);
            this.VolverCS.TabIndex = 15;
            this.VolverCS.Text = "Volver";
            this.VolverCS.UseVisualStyleBackColor = true;
            // 
            // Cesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.VolverCS);
            this.Controls.Add(this.ResultCS);
            this.Controls.Add(this.CifrarCS);
            this.Controls.Add(this.DescifrarCS);
            this.Controls.Add(this.DigiteTextoCs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextCesar);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cesar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifrado Cesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextCesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DigiteTextoCs;
        private System.Windows.Forms.Button DescifrarCS;
        private System.Windows.Forms.Button CifrarCS;
        private System.Windows.Forms.Label ResultCS;
        private System.Windows.Forms.Button VolverCS;
    }
}
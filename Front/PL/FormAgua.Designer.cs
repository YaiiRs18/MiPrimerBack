namespace PL
{
    partial class FormAgua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgua));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.ImagenLuz = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Cable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsaldoag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(313, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Referencia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(313, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa la Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Imagen
            // 
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(-7, -2);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(799, 443);
            this.Imagen.TabIndex = 5;
            this.Imagen.Text = "l";
            this.Imagen.Visible = false;
            this.Imagen.Click += new System.EventHandler(this.label3_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Titulo.Location = new System.Drawing.Point(285, 80);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(62, 19);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "label4";
            // 
            // ImagenLuz
            // 
            this.ImagenLuz.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLuz.Image")));
            this.ImagenLuz.Location = new System.Drawing.Point(-4, -2);
            this.ImagenLuz.Name = "ImagenLuz";
            this.ImagenLuz.Size = new System.Drawing.Size(796, 443);
            this.ImagenLuz.TabIndex = 7;
            this.ImagenLuz.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.Image = ((System.Drawing.Image)(resources.GetObject("Telefono.Image")));
            this.Telefono.Location = new System.Drawing.Point(20, -2);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(737, 443);
            this.Telefono.TabIndex = 8;
            this.Telefono.Visible = false;
            // 
            // Cable
            // 
            this.Cable.Image = ((System.Drawing.Image)(resources.GetObject("Cable.Image")));
            this.Cable.Location = new System.Drawing.Point(3, -2);
            this.Cable.Name = "Cable";
            this.Cable.Size = new System.Drawing.Size(789, 443);
            this.Cable.TabIndex = 9;
            this.Cable.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            this.label3.Visible = false;
            // 
            // labelsaldoag
            // 
            this.labelsaldoag.AutoSize = true;
            this.labelsaldoag.Location = new System.Drawing.Point(655, 38);
            this.labelsaldoag.Name = "labelsaldoag";
            this.labelsaldoag.Size = new System.Drawing.Size(0, 13);
            this.labelsaldoag.TabIndex = 11;
            this.labelsaldoag.Visible = false;
            // 
            // FormAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelsaldoag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.ImagenLuz);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Cable);
            this.Name = "FormAgua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Imagen;
        public System.Windows.Forms.Label Titulo;
        public System.Windows.Forms.Label ImagenLuz;
        public System.Windows.Forms.Label Telefono;
        public System.Windows.Forms.Label Cable;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelsaldoag;
    }
}
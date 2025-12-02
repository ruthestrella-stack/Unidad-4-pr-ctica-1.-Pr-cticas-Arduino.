namespace HyT
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.temperaturalabel = new System.Windows.Forms.Label();
            this.humedadLabel = new System.Windows.Forms.Label();
            this.botonConectar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temperaturalabel
            // 
            this.temperaturalabel.AutoSize = true;
            this.temperaturalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperaturalabel.Location = new System.Drawing.Point(50, 80);
            this.temperaturalabel.Name = "temperaturalabel";
            this.temperaturalabel.Size = new System.Drawing.Size(175, 24);
            this.temperaturalabel.TabIndex = 0;
            this.temperaturalabel.Text = "TEMPERATURA °C";
            // 
            // humedadLabel
            // 
            this.humedadLabel.AutoSize = true;
            this.humedadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humedadLabel.Location = new System.Drawing.Point(50, 120);
            this.humedadLabel.Name = "humedadLabel";
            this.humedadLabel.Size = new System.Drawing.Size(143, 24);
            this.humedadLabel.TabIndex = 1;
            this.humedadLabel.Text = "HUMEDAD %";
            // 
            // botonConectar
            // 
            this.botonConectar.BackColor = System.Drawing.Color.Blue;
            this.botonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConectar.ForeColor = System.Drawing.Color.White;
            this.botonConectar.Location = new System.Drawing.Point(50, 170);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(150, 40);
            this.botonConectar.TabIndex = 2;
            this.botonConectar.Text = "CONECTAR";
            this.botonConectar.UseVisualStyleBackColor = false;
            this.botonConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(250, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 180);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(50, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperatura y Humedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Historial de lecturas: Temperatura (ºC)    Humedad (%)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.humedadLabel);
            this.Controls.Add(this.temperaturalabel);
            this.Name = "Form1";
            this.Text = "Sensor DHT11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperaturalabel;
        private System.Windows.Forms.Label humedadLabel;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
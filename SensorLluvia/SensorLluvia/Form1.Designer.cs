namespace SensorLluvia
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
            components = new System.ComponentModel.Container();
            labelTitulo = new Label();
            labelEstado = new Label();
            botonComenzar = new Button();
            botonSalir = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(107, 31);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(280, 31);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Sensor Lluvia FC-37";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.Location = new Point(133, 108);
            labelEstado.Margin = new Padding(4, 0, 4, 0);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(232, 29);
            labelEstado.TabIndex = 1;
            labelEstado.Text = "Sensor Status: N/A";
            // 
            // botonComenzar
            // 
            botonComenzar.BackColor = Color.Green;
            botonComenzar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonComenzar.ForeColor = Color.White;
            botonComenzar.Location = new Point(67, 231);
            botonComenzar.Margin = new Padding(4, 5, 4, 5);
            botonComenzar.Name = "botonComenzar";
            botonComenzar.Size = new Size(160, 62);
            botonComenzar.TabIndex = 2;
            botonComenzar.Text = "Comenzar";
            botonComenzar.UseVisualStyleBackColor = false;
            botonComenzar.Click += botonComenzar_Click;
            // 
            // botonSalir
            // 
            botonSalir.BackColor = Color.Red;
            botonSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonSalir.ForeColor = Color.White;
            botonSalir.Location = new Point(267, 231);
            botonSalir.Margin = new Padding(4, 5, 4, 5);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(160, 62);
            botonSalir.TabIndex = 3;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = false;
            botonSalir.Click += Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(193, 142);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 72);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 338);
            Controls.Add(pictureBox1);
            Controls.Add(botonSalir);
            Controls.Add(botonComenzar);
            Controls.Add(labelEstado);
            Controls.Add(labelTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Sensor de Lluvia";
            FormClosing += OnFormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button botonComenzar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
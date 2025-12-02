namespace ControlLED
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Button buttonON;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonOFF = new Button();
            buttonON = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOFF
            // 
            buttonOFF.Location = new Point(0, 196);
            buttonOFF.Name = "buttonOFF";
            buttonOFF.Size = new Size(133, 72);
            buttonOFF.TabIndex = 1;
            buttonOFF.Text = "OFF";
            buttonOFF.UseVisualStyleBackColor = true;
            buttonOFF.Click += buttonOFF_Click;
            // 
            // buttonON
            // 
            buttonON.Location = new Point(137, 196);
            buttonON.Name = "buttonON";
            buttonON.Size = new Size(133, 72);
            buttonON.TabIndex = 0;
            buttonON.Text = "ON";
            buttonON.UseVisualStyleBackColor = true;
            buttonON.Click += buttonON_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 195);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(269, 266);
            Controls.Add(pictureBox1);
            Controls.Add(buttonON);
            Controls.Add(buttonOFF);
            Name = "Form1";
            Text = "Control LED Arduino";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
    }
}
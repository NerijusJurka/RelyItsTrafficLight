namespace RelyItsTrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            green = new PictureBox();
            red = new PictureBox();
            yellowRed = new PictureBox();
            yellow = new PictureBox();
            Start = new Button();
            ((System.ComponentModel.ISupportInitialize)green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellow).BeginInit();
            SuspendLayout();
            // 
            // green
            // 
            green.Image = Properties.Resources.GreenLight;
            green.Location = new Point(12, 12);
            green.Name = "green";
            green.Size = new Size(326, 586);
            green.TabIndex = 1;
            green.TabStop = false;
            // 
            // red
            // 
            red.Image = Properties.Resources.RedLight;
            red.Location = new Point(12, 12);
            red.Name = "red";
            red.Size = new Size(326, 586);
            red.TabIndex = 2;
            red.TabStop = false;
            // 
            // yellowRed
            // 
            yellowRed.Image = Properties.Resources.RedYellowLight;
            yellowRed.Location = new Point(12, 12);
            yellowRed.Name = "yellowRed";
            yellowRed.Size = new Size(326, 586);
            yellowRed.TabIndex = 3;
            yellowRed.TabStop = false;
            // 
            // yellow
            // 
            yellow.Image = Properties.Resources.YellowLight;
            yellow.Location = new Point(12, 12);
            yellow.Name = "yellow";
            yellow.Size = new Size(326, 586);
            yellow.TabIndex = 4;
            yellow.TabStop = false;
            yellow.Click += Yellow_Click;
            // 
            // Start
            // 
            Start.Location = new Point(344, 12);
            Start.Name = "Start";
            Start.Size = new Size(172, 44);
            Start.TabIndex = 5;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(634, 610);
            Controls.Add(Start);
            Controls.Add(yellow);
            Controls.Add(yellowRed);
            Controls.Add(red);
            Controls.Add(green);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)green).EndInit();
            ((System.ComponentModel.ISupportInitialize)red).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Stoplight stoplight = new Stoplight(green, red, yellowRed, yellow);
            stoplight.Start();
        }

        private void Yellow_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace RelyItsTrafficLight
{
    public partial class Form1 : Form
    {
        private Stoplight stoplight;
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
            button1 = new Button();
            redtextBox = new TextBox();
            yeltextBox = new TextBox();
            minGretextBox = new TextBox();
            MaxGretextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            yelRedtextBox = new TextBox();
            label5 = new Label();
            Apply = new Button();
            label6 = new Label();
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
            // button1
            // 
            button1.Location = new Point(344, 277);
            button1.Name = "button1";
            button1.Size = new Size(165, 54);
            button1.TabIndex = 5;
            button1.Text = "Pedestrian Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // redtextBox
            // 
            redtextBox.Location = new Point(344, 72);
            redtextBox.Name = "redtextBox";
            redtextBox.Size = new Size(165, 23);
            redtextBox.TabIndex = 6;
            redtextBox.TextChanged += textBox1_TextChanged;
            // 
            // yeltextBox
            // 
            yeltextBox.Location = new Point(344, 101);
            yeltextBox.Name = "yeltextBox";
            yeltextBox.Size = new Size(165, 23);
            yeltextBox.TabIndex = 7;
            yeltextBox.TextChanged += textBox2_TextChanged;
            // 
            // minGretextBox
            // 
            minGretextBox.Location = new Point(344, 130);
            minGretextBox.Name = "minGretextBox";
            minGretextBox.Size = new Size(165, 23);
            minGretextBox.TabIndex = 8;
            // 
            // MaxGretextBox
            // 
            MaxGretextBox.Location = new Point(344, 159);
            MaxGretextBox.Name = "MaxGretextBox";
            MaxGretextBox.Size = new Size(165, 23);
            MaxGretextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 75);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 10;
            label1.Text = "RedLight Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 104);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 11;
            label2.Text = "YellowLight Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 133);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 12;
            label3.Text = "MinGreenLight Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 162);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 13;
            label4.Text = "MaxGreenLight Duration";
            // 
            // yelRedtextBox
            // 
            yelRedtextBox.Location = new Point(344, 188);
            yelRedtextBox.Name = "yelRedtextBox";
            yelRedtextBox.Size = new Size(165, 23);
            yelRedtextBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 191);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 15;
            label5.Text = "RedYellowLight Duration";
            // 
            // Apply
            // 
            Apply.Location = new Point(344, 217);
            Apply.Name = "Apply";
            Apply.Size = new Size(165, 54);
            Apply.TabIndex = 16;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = true;
            Apply.Click += Button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 54);
            label6.Name = "label6";
            label6.Size = new Size(145, 15);
            label6.TabIndex = 17;
            label6.Text = "Time Settings 1000 = 1 sec";
            // 
            // Form1
            // 
            ClientSize = new Size(653, 610);
            Controls.Add(label6);
            Controls.Add(Apply);
            Controls.Add(label5);
            Controls.Add(yelRedtextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MaxGretextBox);
            Controls.Add(minGretextBox);
            Controls.Add(yeltextBox);
            Controls.Add(redtextBox);
            Controls.Add(button1);
            Controls.Add(yellow);
            Controls.Add(yellowRed);
            Controls.Add(red);
            Controls.Add(green);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)green).EndInit();
            ((System.ComponentModel.ISupportInitialize)red).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default duration values
            redtextBox.Text = "120000";
            yeltextBox.Text = "5000";
            minGretextBox.Text = "120000";
            MaxGretextBox.Text = "360000";
            yelRedtextBox.Text = "5000";

            // Create the initial instance of Stoplight
            int redDuration = int.Parse(redtextBox.Text);
            int yelDuration = int.Parse(yeltextBox.Text);
            int minGreDuration = int.Parse(minGretextBox.Text);
            int maxGreDuration = int.Parse(MaxGretextBox.Text);
            int redYelDuration = int.Parse(yelRedtextBox.Text);

            stoplight = new Stoplight(green, red, yellowRed, yellow, redDuration, yelDuration, minGreDuration, maxGreDuration, redYelDuration);
            stoplight.Start();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            // Update the duration values
            int redDuration = int.Parse(redtextBox.Text);
            int yelDuration = int.Parse(yeltextBox.Text);
            int minGreDuration = int.Parse(minGretextBox.Text);
            int maxGreDuration = int.Parse(MaxGretextBox.Text);
            int redYelDuration = int.Parse(yelRedtextBox.Text);

            if (stoplight != null)
            {
                stoplight.Stop();
            }

            stoplight = new Stoplight(green, red, yellowRed, yellow, redDuration, yelDuration, minGreDuration, maxGreDuration, redYelDuration);
            stoplight.Start();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            stoplight.ButtonClick();
        }
        //----------------------------------------------------
        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Yellow_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
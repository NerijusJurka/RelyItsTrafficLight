using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

public class Stoplight
{
    private System.Windows.Forms.Timer redTimer;
    private System.Windows.Forms.Timer greenTimer;
    private System.Windows.Forms.Timer yellowTimer;
    private System.Windows.Forms.Timer yellowRedTimer;

    public PictureBox RedPictureBox { get; private set; }
    public PictureBox GreenPictureBox { get; private set; }
    public PictureBox YellowPictureBox { get; private set; }
    public PictureBox YellowRedPictureBox { get; private set; }

    public Stoplight(PictureBox green, PictureBox red, PictureBox yellowRed, PictureBox yellow)
    {
        GreenPictureBox = green;
        RedPictureBox = red;
        YellowRedPictureBox = yellowRed;
        YellowPictureBox = yellow;

        InitializeComponents();
        InitializeTimers();
    }

    private void InitializeComponents()
    {
        RedPictureBox.Image = RelyItsTrafficLight.Properties.Resources.RedLight;
        //RedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        GreenPictureBox.Image = RelyItsTrafficLight.Properties.Resources.GreenLight;
        //GreenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        YellowPictureBox.Image = RelyItsTrafficLight.Properties.Resources.YellowLight;
        //YellowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        YellowRedPictureBox.Image = RelyItsTrafficLight.Properties.Resources.RedYellowLight;
        //YellowRedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void InitializeTimers()
    {
        redTimer = new System.Windows.Forms.Timer();
        redTimer.Tick += OnRedTimerElapsed;

        greenTimer = new System.Windows.Forms.Timer();
        greenTimer.Tick += OnGreenTimerElapsed;

        yellowTimer = new System.Windows.Forms.Timer();
        yellowTimer.Tick += OnYellowTimerElapsed;

        yellowRedTimer = new System.Windows.Forms.Timer();
        yellowRedTimer.Tick += OnYellowRedTimerElapsed;
    }

    public void Start()
    {
        RedPictureBox.Visible = true;
        GreenPictureBox.Visible = false;
        YellowPictureBox.Visible = false;
        YellowRedPictureBox.Visible = false;

        redTimer.Interval = 1;
        redTimer.Start();
    }

    private void OnRedTimerElapsed(object sender, EventArgs e)
    {
        RedPictureBox.Visible = true;
        GreenPictureBox.Visible = false;
        YellowPictureBox.Visible = false;
        YellowRedPictureBox.Visible = false;

        redTimer.Stop();
        yellowRedTimer.Interval = 5000;
        yellowRedTimer.Start();
    }

    private void OnYellowRedTimerElapsed(object sender, EventArgs e)
    {
        RedPictureBox.Visible = false;
        GreenPictureBox.Visible = false;
        YellowPictureBox.Visible = false;
        YellowRedPictureBox.Visible = true;

        yellowRedTimer.Stop();
        greenTimer.Interval = 5000;
        greenTimer.Start();
    }

    private void OnGreenTimerElapsed(object sender, EventArgs e)
    {
        RedPictureBox.Visible = false;
        GreenPictureBox.Visible = true;
        YellowPictureBox.Visible = false;
        YellowRedPictureBox.Visible = false;

        greenTimer.Stop();
        yellowTimer.Interval = GetRandomGreenLightDuration();
        yellowTimer.Start();
    }


    private void OnYellowTimerElapsed(object sender, EventArgs e)
    {
        RedPictureBox.Visible = false;
        GreenPictureBox.Visible = false;
        YellowPictureBox.Visible = true;
        YellowRedPictureBox.Visible = false;

        yellowTimer.Stop();
        redTimer.Interval = 5000;
        redTimer.Start();
    }

    private static int GetRandomGreenLightDuration()
    {
        Random random = new Random();
        return random.Next(120000, 360001); // Random duration between 2 and 6 minutes
    }
}
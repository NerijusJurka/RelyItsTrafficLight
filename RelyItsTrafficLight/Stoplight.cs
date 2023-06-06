public class Stoplight
{
    private PictureBox greenLight;
    private PictureBox redLight;
    private PictureBox yellowRedLight;
    private PictureBox yellowLight;

    private int redDuration;
    private int yellowDuration;
    private int minGreenDuration;
    private int maxGreenDuration;
    private int redYellowDuration;

    private System.Windows.Forms.Timer timer;

    private bool isGreenActive;
    private bool isRedActive;
    private bool isYellowActive;
    private bool isRedYellowActive;

    public Stoplight(PictureBox green, PictureBox red, PictureBox yellowRed, PictureBox yellow,
        int redDuration, int yellowDuration, int minGreenDuration, int maxGreenDuration, int redYellowDuration)
    {
        greenLight = green;
        redLight = red;
        yellowRedLight = yellowRed;
        yellowLight = yellow;

        this.redDuration = redDuration;
        this.yellowDuration = yellowDuration;
        this.minGreenDuration = minGreenDuration;
        this.maxGreenDuration = maxGreenDuration;
        this.redYellowDuration = redYellowDuration;

        timer = new System.Windows.Forms.Timer();
        timer.Tick += Timer_Tick;
    }

    public void Start()
    {
        redLight.Visible = true;
        greenLight.Visible = false;
        yellowRedLight.Visible = false;
        yellowLight.Visible = false;

        isGreenActive = false;
        isRedActive = true;
        isYellowActive = false;
        isRedYellowActive = false;

        timer.Interval = redDuration;
        timer.Start();
    }

    public void Stop()
    {
        timer.Stop();
        timer.Dispose();
    }
    public void ButtonClick()
    {
        if (isRedActive)
        {
            return;
        }
        else if (isGreenActive)
        {
            int remainingGreenDuration = Math.Max(maxGreenDuration - timer.Interval, 0);

            timer.Interval = remainingGreenDuration < 30 * 1000 ? remainingGreenDuration : maxGreenDuration;
        }

        greenLight.Visible = true;
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
        if (isRedActive)
        {
            redLight.Visible = false;
            yellowRedLight.Visible = true;
            isRedActive = false;
            isRedYellowActive = true;

            timer.Interval = redYellowDuration;
        }
        else if (isRedYellowActive)
        {
            yellowRedLight.Visible = false;
            greenLight.Visible = true;
            isRedYellowActive = false;
            isGreenActive = true;

            Random random = new Random();
            int randomGreenDuration = random.Next(minGreenDuration, maxGreenDuration + 1);
            timer.Interval = randomGreenDuration;
        }
        else if (isGreenActive)
        {
            greenLight.Visible = false;
            yellowLight.Visible = true;
            isGreenActive = false;
            isYellowActive = true;

            timer.Interval = yellowDuration;

            if (timer.Interval >= maxGreenDuration)
            {
                yellowLight.Visible = false;
                redLight.Visible = true;
                isYellowActive = false;
                isRedActive = true;

                int remainingRedDuration = timer.Interval - maxGreenDuration;
                timer.Interval = remainingRedDuration < redDuration ? remainingRedDuration : redDuration;
            }
        }
        else if (isYellowActive)
        {
            yellowLight.Visible = false;
            redLight.Visible = true;
            isYellowActive = false;
            isRedActive = true;

            timer.Interval = redDuration;
        }
    }
    public bool IsRedLightVisible => redLight.Visible;
    public bool IsGreenLightVisible => greenLight.Visible;
    public bool IsYellowRedLightVisible => yellowRedLight.Visible;
    public bool IsYellowLightVisible => yellowLight.Visible;
    public bool IsRedActive => isRedActive;
    public void SetInternalState(bool green, bool red, bool yellowRed, bool yellow)
    {
        isGreenActive = green;
        isRedActive = red;
        isYellowActive = yellow;
        isRedYellowActive = yellowRed;
    }
    public int GetTimerInterval()
    {
        return timer.Interval;
    }
    public int MaxGreenDuration
    {
        get { return maxGreenDuration; }
        set { maxGreenDuration = value; }
    }
}
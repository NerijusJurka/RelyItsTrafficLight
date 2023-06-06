
using System.Windows.Forms;

namespace TestStopLight.UnitTest
{
    [TestClass]
    public class StoplightTests
    {
        private Stoplight stoplight;
        private PictureBox greenLight;
        private PictureBox redLight;
        private PictureBox yellowRedLight;
        private PictureBox yellowLight;

        [TestInitialize]
        public void Setup()
        {
            greenLight = new PictureBox();
            redLight = new PictureBox();
            yellowRedLight = new PictureBox();
            yellowLight = new PictureBox();

            stoplight = new Stoplight(
                green: greenLight,
                red: redLight,
                yellowRed: yellowRedLight,
                yellow: yellowLight,
                redDuration: 5000,
                yellowDuration: 5000,
                minGreenDuration: 60000,
                maxGreenDuration: 120000,
                redYellowDuration: 5000
            );
        }

        [TestMethod]
        public void Start_StoplightShouldInitializeWithRedLightVisible()
        {
            stoplight.Start();

            Assert.IsTrue(stoplight.IsRedLightVisible);
            Assert.IsFalse(stoplight.IsGreenLightVisible);
            Assert.IsFalse(stoplight.IsYellowRedLightVisible);
            Assert.IsFalse(stoplight.IsYellowLightVisible);
        }

        [TestMethod]
        public void ButtonClick_WhenRedLightActive_NoChangeInState()
        {
            stoplight.Start();

            stoplight.ButtonClick();

            Assert.IsTrue(stoplight.IsRedLightVisible);
            Assert.IsFalse(stoplight.IsGreenLightVisible);
            Assert.IsFalse(stoplight.IsYellowRedLightVisible);
            Assert.IsFalse(stoplight.IsYellowLightVisible);
        }

        [TestMethod]
        public void ButtonClick_WhenGreenLightActive_ContinuesWithMaxGreenDuration()
        {
            stoplight.Start();

            stoplight.SetInternalState(true, false, false, false);

            stoplight.ButtonClick();

            Assert.IsTrue(stoplight.IsGreenLightVisible);
            Assert.IsFalse(stoplight.IsYellowRedLightVisible);
            Assert.IsFalse(stoplight.IsYellowLightVisible);

            Assert.AreEqual(stoplight.MaxGreenDuration, stoplight.GetTimerInterval());
        }

        [TestMethod]
        public void ButtonClick_WhenGreenLightActive_ExceedsMaxGreenDuration_TurnsRed()
        {
            stoplight.Start();


            stoplight.SetInternalState(true, false, false, false);

            System.Threading.Thread.Sleep(stoplight.MaxGreenDuration + 1000);

            stoplight.ButtonClick();

            Assert.IsTrue(stoplight.IsGreenLightVisible);
            Assert.IsFalse(stoplight.IsYellowLightVisible);
            Assert.IsTrue(stoplight.IsRedLightVisible);
            Assert.IsFalse(stoplight.IsYellowRedLightVisible);
            Assert.IsFalse(stoplight.IsRedActive);

            System.Threading.Thread.Sleep(stoplight.GetTimerInterval());

            Assert.IsTrue(stoplight.IsRedLightVisible);
            Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        }
    }
}
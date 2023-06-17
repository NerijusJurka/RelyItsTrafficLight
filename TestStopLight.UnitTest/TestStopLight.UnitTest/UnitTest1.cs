using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

[TestClass]
public class StoplightTests
{
    private Stoplight stoplight;

    [TestInitialize]
    public void Setup()
    {
        // Create a new Stoplight instance with the necessary parameters
        stoplight = new Stoplight(
            green: new PictureBox(),
            red: new PictureBox(),
            yellowRed: new PictureBox(),
            yellow: new PictureBox(),
            redDuration: 5000,
            yellowDuration: 2000,
            minGreenDuration: 3000,
            maxGreenDuration: 10000,
            redYellowDuration: 3000
        );
    }

    [TestMethod]
    public void ButtonClick_WhenRedActive_TurnsRedYellow()
    {
        // Arrange
        stoplight.SetInternalState(false, true, false, false);

        // Act
        stoplight.ButtonClick();

        // Assert
        Assert.IsFalse(stoplight.IsRedActive);
        Assert.IsTrue(stoplight.IsRedYellowActive);
        Assert.IsFalse(stoplight.IsGreenLightVisible);
        Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        Assert.IsFalse(stoplight.IsYellowLightVisible);
        Assert.IsTrue(stoplight.IsRedLightVisible);
    }

    [TestMethod]
    public void ButtonClick_WhenGreenActive_ExceedsMaxGreenDuration_TurnsYellow()
    {
        // Arrange
        stoplight.SetInternalState(true, false, false, false);
        stoplight.TimerInterval = stoplight.MaxGreenDuration + 2000;

        // Act
        stoplight.ButtonClick();

        // Assert
        Assert.IsFalse(stoplight.IsGreenLightVisible);
        Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        Assert.IsTrue(stoplight.IsYellowLightVisible);
        Assert.IsTrue(stoplight.IsRedLightVisible);
        Assert.IsFalse(stoplight.IsRedActive);
        Assert.IsTrue(stoplight.IsYellowActive);
    }

    [TestMethod]
    public void ButtonClick_WhenYellowActive_TurnsRed()
    {
        // Arrange
        stoplight.SetInternalState(false, false, true, false);

        // Act
        stoplight.ButtonClick();

        // Assert
        Assert.IsFalse(stoplight.IsYellowActive);
        Assert.IsTrue(stoplight.IsRedActive);
        Assert.IsFalse(stoplight.IsGreenLightVisible);
        Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        Assert.IsFalse(stoplight.IsYellowLightVisible);
        Assert.IsTrue(stoplight.IsRedLightVisible);
    }

    [TestMethod]
    public void TimerTick_WhenRedActive_TurnsRedYellow()
    {
        // Arrange
        stoplight.SetInternalState(false, true, false, false);

        // Act
        stoplight.Timer_Tick(null, EventArgs.Empty);

        // Assert
        Assert.IsFalse(stoplight.IsRedActive);
        Assert.IsTrue(stoplight.IsRedYellowActive);
        Assert.IsFalse(stoplight.IsGreenLightVisible);
        Assert.IsTrue(stoplight.IsYellowRedLightVisible);
        Assert.IsFalse(stoplight.IsYellowLightVisible);
        Assert.IsFalse(stoplight.IsRedLightVisible);
    }

    [TestMethod]
    public void TimerTick_WhenRedYellowActive_TurnsGreen()
    {
        // Arrange
        stoplight.SetInternalState(false, false, false, true);

        // Act
        stoplight.Timer_Tick(null, EventArgs.Empty);

        // Assert
        Assert.IsFalse(stoplight.IsRedYellowActive);
        Assert.IsTrue(stoplight.IsGreenLightVisible);
        Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        Assert.IsFalse(stoplight.IsYellowLightVisible);
        Assert.IsFalse(stoplight.IsRedLightVisible);
        Assert.IsTrue(stoplight.IsGreenLightVisible);
    }

    [TestMethod]
    public void TimerTick_WhenGreenActive_ExceedsMaxGreenDuration_TurnsYellow()
    {
        // Arrange
        stoplight.SetInternalState(true, false, false, false);
        stoplight.TimerInterval = stoplight.MaxGreenDuration + 2000;

        // Act
        stoplight.Timer_Tick(null, EventArgs.Empty);

        // Assert
        Assert.IsFalse(stoplight.IsGreenLightVisible);
        Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        Assert.IsTrue(stoplight.IsYellowLightVisible);
        Assert.IsTrue(stoplight.IsRedLightVisible);
        Assert.IsFalse(stoplight.IsRedActive);
        Assert.IsTrue(stoplight.IsYellowActive);
    }

    [TestMethod]
    public void TimerTick_WhenYellowActive_TurnsRed()
    {
        // Arrange
        stoplight.SetInternalState(false, false, true, false);

        // Act
        stoplight.Timer_Tick(null, EventArgs.Empty);

        // Assert
        Assert.IsFalse(stoplight.IsYellowActive);
        Assert.IsTrue(stoplight.IsRedActive);
        Assert.IsFalse(stoplight.IsGreenLightVisible);
        Assert.IsFalse(stoplight.IsYellowRedLightVisible);
        Assert.IsFalse(stoplight.IsYellowLightVisible);
        Assert.IsTrue(stoplight.IsRedLightVisible);
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_19.Tests
{
    using Listing13_19;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AddRemoveHandlerWorks()
        {
            Thermostat t = new Thermostat();

            float temp = 0;

            Thermostat.TemperatureChangeHandler T_OnTemperatureChange = (sender, newTemperature) =>
            {
                temp = newTemperature.NewTemperature;
            };
            t.OnTemperatureChange += T_OnTemperatureChange;

            t.CurrentTemperature = 12;
            Assert.AreEqual(12, temp);

            t.OnTemperatureChange -= T_OnTemperatureChange;
            t.CurrentTemperature = 20;
            Assert.AreEqual(12, temp);

        }

    }
}
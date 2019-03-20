﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TaskyUITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        // https://nftb.saturdaymp.com/today-i-learned-how-to-create-xamarin-ios-and-android-unit-tests/
        [Test]
        public void SmokeTest()
        {
            Assert.That(true);
        }

        [Test]
        public void EnterTextExample()
        {
            app.Tap(x => x.Marked("Add Task"));
            app.Tap(x => x.Text("Item name"));

            app.Screenshot("Before calling EnterText");
            app.EnterText("The test worked!");
            app.Screenshot("Text entered");
            app.Back();
        }
    }
}


using NUnit.Framework;
using Xamarin.UITest;

namespace UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
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

        [Test, Description("Smoke Test")]
        public void AppLaunches()
        {
            app.WaitForElement(c => c.Id("content"));
            app.Screenshot("App launched");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleCodingQuestion.Tests
{
    [TestClass]
    public class ImageCalculatorTests
    {
        [TestMethod]
        public void LessThan6Args_ReturnsUsageMessage()
        {
            var args = new[] { "0", "50", "0", "60", "10" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("Six arguments not provided.  Proper usage is: TriangleCodingQuestion.exe <V1X> <V1Y> <V2X> <V2Y> <V3X> <V3Y>", output);
        }

        [TestMethod]
        public void MoreThan6Args_ReturnsUsageMessage()
        {
            var args = new[] { "0", "50", "0", "60", "10", "50", "50" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("Six arguments not provided.  Proper usage is: TriangleCodingQuestion.exe <V1X> <V1Y> <V2X> <V2Y> <V3X> <V3Y>", output);
        }

        [TestMethod]
        public void OneArgNotInteger_ReturnsOnlyIntegerMessage()
        {
            var args = new[] { "0", "50", "F6", "60", "10", "50" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("Please provide only integers as arguments for coordinates.", output);
        }

        [TestMethod]
        public void Coordinates_0_50_0_60_10_50_Returns_A1()
        {
            var args = new[] { "0", "50", "0", "60", "10", "50" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("A1", output);
        }

        [TestMethod]
        public void Coordinates_40_50_40_40_30_50_Returns_B8()
        {
            var args = new[] { "40", "50", "40", "40", "30", "50" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("B8", output);
        }

        [TestMethod]
        public void Coordinates_20_20_20_30_30_20_Returns_D5()
        {
            var args = new[] { "20", "20", "20", "30", "30", "20" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("D5", output);
        }

        [TestMethod]
        public void Coordinates_60_10_60_0_50_10_Returns_F12()
        {
            var args = new[] { "60", "10", "60", "0", "50", "10" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("F12", output);
        }

        [TestMethod]
        public void InvalidCoordinates_ReturnsNotFoundMessage()
        {
            var args = new[] { "60", "60", "60", "60", "60", "60" };
            var imageCalculator = new ImageCalculator();

            var output = imageCalculator.GetImageTriangle(args);

            Assert.AreEqual("Image triangle not found for supplied coordinates", output);
        }
    }
}

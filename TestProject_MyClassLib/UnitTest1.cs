namespace TestProject_MyClassLib
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMethod1()
        {
        }

        public static void TestYearsOfExp()
        {
            emp e1 = new emp(5050, "Mary", new DateOnly(2005, 8, 31));
            int experience = 17;

            int actual = e1.GetYearsofExp();
            Assert.AreEqual(experience, actual);

        }

        public static void TestMethod11()
        {
            //Arrange
            emp e1 = new emp(5050, "Mary", new DateOnly(2005, 8, 31));
            DateOnly expected = new DateOnly(2005, 8, 31);

            //Act
            DateOnly actual = e1.doj;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
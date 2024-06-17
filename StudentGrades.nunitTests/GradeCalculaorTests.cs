namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(90)]
        [TestCase(50)]
        [TestCase(70)]

        public void GetGradeByPercentage_Test(int percentage)
        {
            //Assign
            //var percentage = 99;

            //Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.AreEqual("A", grade);
        }
    }
}

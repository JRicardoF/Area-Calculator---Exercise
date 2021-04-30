using NRI_Distribution_Exercise_Domain.Util;
using Xunit;


namespace Unit_Testing
{
    public class UnitTest1
    {

        private int areaType;
        private int n1;
        private int n2;

        #region 1-Square
        [Fact]
        public void Testing_Method_Square_Returning_Correct_Answer_1()
        {
            //Arrange
            areaType = 1;
            n1 = 5;
            int expectedAnswer = 25;            

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, 0);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Square_Returning_Correct_Answer_2()
        {
            //Arrange
            areaType = 1;
            n1 = 4;
            int expectedAnswer = 16;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, 0);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Square_Returning_Correct_Answer_3()
        {
            //Arrange
            areaType = 1;
            n1 = 3;
            int expectedAnswer = 9;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, 0);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        #endregion

        #region 2-Triangle
        [Fact]
        public void Testing_Method_Triangle_Returning_Correct_Answer_1()
        {
            //Arrange
            areaType = 2;
            n1 = 3;
            n2 = 2;
            int expectedAnswer = 3;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, n2);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Triangle_Returning_Correct_Answer_2()
        {
            //Arrange
            areaType = 2;
            n1 = 5;
            n2 = 4;
            int expectedAnswer = 10;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, n2);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Triangle_Returning_Correct_Answer_3()
        {
            //Arrange
            areaType = 2;
            n1 = 7;
            n2 = 6;
            int expectedAnswer = 21;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, n2);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        #endregion

        #region 3-Rectangle
        [Fact]
        public void Testing_Method_Rectangle_Returning_Correct_Answer_1()
        {
            //Arrange
            areaType = 3;
            n1 = 4;
            n2 = 3;
            int expectedAnswer = 12;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, n2);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Rectangle_Returning_Correct_Answer_2()
        {
            //Arrange
            areaType = 3;
            n1 = 6;
            n2 = 4;
            int expectedAnswer = 24;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, n2);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Rectangle_Returning_Correct_Answer_3()
        {
            //Arrange
            areaType = 3;
            n1 = 7;
            n2 = 6;
            int expectedAnswer = 42;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, n2);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        #endregion

        #region 4-Hexagon
        [Fact]
        public void Testing_Method_Hexagon_Returning_Correct_Answer_1()
        {
            //Arrange
            areaType = 4;
            n1 = 5;
            int expectedAnswer = 64;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, 0);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Hexagon_Returning_Correct_Answer_2()
        {
            //Arrange
            areaType = 4;
            n1 = 6;
            int expectedAnswer = 93;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, 0);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        [Fact]
        public void Testing_Method_Hexagon_Returning_Correct_Answer_3()
        {
            //Arrange
            areaType = 4;
            n1 = 7;
            int expectedAnswer = 127;

            //Act
            int actualArea = AreaCalculator.AreaCalc(areaType, n1, 0);
            int testWrongAnswer = expectedAnswer + 2;

            //Assert
            Assert.Equal(actualArea, expectedAnswer);
            Assert.NotEqual(actualArea, testWrongAnswer);
        }
        #endregion

    }
}

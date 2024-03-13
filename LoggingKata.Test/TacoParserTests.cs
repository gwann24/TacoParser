using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth...", -84.575512)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.22997,-86.805275,Taco Bell Alabaste...", -86.805275)]
        [InlineData("31.570771,-84.10353,Taco Bell Albany...", -84.10353)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("34.047374,-84.223918, Taco Bell Alpharetta...", -84.223918)]

        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;

            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test called ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth...", 34.087508)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", 34.376395)]
        [InlineData("33.22997,-86.805275,Taco Bell Alabaste...", 33.22997)]
        [InlineData("31.570771,-84.10353,Taco Bell Albany...", 31.570771)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("34.047374,-84.223918, Taco Bell Alpharetta...", 34.047374)]
        public void ShouldParseLatitude(string line, double expected)
        {

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var tacoParseData = line.Split(',');
            var actual = tacoParser.Parse(line).Location.Latitude;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}

using Classes;
using Classes.Enum;

namespace TestProject
{
    public class SpectatorTests
    {
        [Fact]
        public void ApplaudsWhenReceiveAcrobaticTrickType()
        {
            //Model AAA

            // Arrange
            var trick = new Trick() { Type = TrickTypes.Acrobatic, Description = "Test" };
            var spectator = new Spectator();
            // Act
            var result = spectator.React(trick);
            // Assert
            Assert.Contains("applauds", result);
        }

        [Fact]
        public void WhistlesWhenReceiveAcrobaticTrickType()
        {
            // arrange
            var trick = new Trick() { Type = TrickTypes.Music, Description = "Test" };
            var spectator = new Spectator();
            // act
            var result = spectator.React(trick);
            // Assert
            Assert.Contains("whistles", result);
        }
    }
}
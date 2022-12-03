using Classes;
using Classes.Enum;

namespace TestProject
{
    public class SpectatorTests
    {
        [Fact]
        public void ApplaudsWhenReceiveAcrobaticTrickType()
        {
            // setup
            var trick = new Trick() { Type = TrickTypes.Acrobatic, Description = "Test" };
            var spectator = new Spectator();
            // arrange
            var result = spectator.React(trick);
            // Assert
            Assert.Contains("applauds", result);
        }

        [Fact]
        public void WhistlesWhenReceiveAcrobaticTrickType()
        {
            // setup
            var trick = new Trick() { Type = TrickTypes.Music, Description = "Test" };
            var spectator = new Spectator();
            // arrange
            var result = spectator.React(trick);
            // Assert
            Assert.Contains("whistles", result);
        }
    }
}
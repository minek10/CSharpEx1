using Classes;
using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TrainerTests
    {
        [Fact]
        public void TestTrainer()
        {
            //setup
            var monkey1 = new Monkey()
            {
                Name = "Monkey 1",
                Tricks = new List<Trick>()
                {
                 new Trick(){ Type = TrickTypes.Acrobatic, Description = "Dance" }
            }
            };

            var trainer1 = new Trainer()
            {
                Name = "Patrice",
                Monkey = monkey1
            };
            var spectator = new Spectator();

            //arrange
        }
    }
}

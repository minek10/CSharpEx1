using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Trainer
    {
        public string Name { get; set; } = String.Empty;
        public Monkey Monkey { get; set; }

        // a trainer expected any reaction when he shows its monkey's tricks 
        public void ShowMonkeyTricks(Func<Trick, string> react) // Func<FirstArgument, ReturnType> == string React(Trick trick) {}
        {
            foreach (var trick in Monkey.Tricks)
            {
                var reaction = react(trick);
                Console.WriteLine($"{reaction} from {Monkey.Name}");
            }
        }
    }
}

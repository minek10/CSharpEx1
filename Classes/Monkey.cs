using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Monkey
    {
        public string Name { get; set; } = String.Empty;
        public List<Trick> Tricks { get; set; } = new List<Trick>();
    }
}

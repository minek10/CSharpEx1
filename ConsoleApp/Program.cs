using Classes;
using Classes.Enum;

//Create instance of spectator
var spectator = new Spectator();

//Create instances of Monkey 1 with Dancing Trick and Trainer 1
//The trainer 1 has a Monkey 1
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


//Create instances of Monkey 2 with 2 tricks (Acrobatic Dance & Sing) & Trainer 2
//The trainer 2 has a Monkey 2
var monkey2 = new Monkey()
{
    Name = "Monkey 2",
    Tricks = new List<Trick>()
    {
        new Trick(){ Type = TrickTypes.Acrobatic, Description = "Does the moonwalk" },
        new Trick(){ Type = TrickTypes.Music, Description = "Sings M. Jackson" }
    }
};

var trainer2 = new Trainer()
{
    Name = "Gilles",
    Monkey = monkey2
};

//Show Console
Console.WriteLine("Trainer 1:");
trainer1.ShowMonkeyTricks(spectator.React);
Console.WriteLine("\nTrainer 2:");
trainer2.ShowMonkeyTricks(spectator.React);
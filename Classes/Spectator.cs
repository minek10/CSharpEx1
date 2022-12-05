using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Spectator
    {
        public string React(Trick trick)
        {
            switch (trick.Type)
            {
                // react based on enum type
                case TrickTypes.Acrobatic:
                    return $" - The spectator applauds while the acrobatic trick '{trick.Description}'";
                case TrickTypes.Music:
                    return $" - The spectator whistles while a musical trick '{trick.Description}'";
                default:
                    return $" - The spectator doesn't know to react";
            }
        }
    }
}

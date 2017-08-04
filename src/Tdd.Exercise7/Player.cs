using System;

namespace Tdd.Exercise7
{
    public class Player : IPlayer
    {
        public Hand RevealHand()
        {//branch modif
            Array values = Enum.GetValues(typeof(Hand));
            Random random = new Random();
           return (Hand)values.GetValue(random.Next(values.Length));
        }
    }
}
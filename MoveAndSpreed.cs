using System;

namespace MyDistanceMove
{
    class MoveAndSpreed : IMove
    {
        public decimal Move(decimal distance, decimal spreed)
        {
            string DistanceStr = Convert.ToString(distance);

            DistanceStr = Console.ReadLine();

            decimal DistanceM = Convert.ToDecimal(DistanceStr); // distance convert.

            string SpreedStr = Convert.ToString(spreed);

            SpreedStr = Console.ReadLine();

            decimal SpreedM = Convert.ToDecimal(SpreedStr); // spreed convert.

            return DistanceM / SpreedM;
        }
    }
}

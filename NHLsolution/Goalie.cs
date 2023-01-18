using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemClassLibrary
{
    internal class Goalie : Player
    {
        private double _savePercentage;

        public double GAA { get; set; }

        public double SavePercentage
        {
            get { return _savePercentage; }
            set
            {
                if(value > 1 || value < 0)
                {
                    throw new ArgumentException(nameof(SavePercentage), "Save percentage must be between 0 and 1");
                }
                _savePercentage = value;
            }
        }

        public int Shutouts { get; private set; }
        public Goalie(int number, string name) : base(number, name, Position.G)
        {

        }
        public Goalie(int number, string name, int gamesPlayed) : base(number, name, Position.G)
        {
            base.GamesPlayed = gamesPlayed;
        }

        public void AddShutout()
        {
            Shutouts++;
        }
    }
}

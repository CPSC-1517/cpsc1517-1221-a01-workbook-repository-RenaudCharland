using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemClassLibrary
{
    public class Player
    {
        const int MINNUMBER = 1;
        const int MAXNUMBER = 98;

        private int _number;
        private string _name;
        private int _gamesPlayed;
        private int _goals;
        private int _assists;
        private int _points;

        public  Position Position { get; private set; }

        public int Number
        {
            get { return _number; }
            private set
            {
                if(value > MAXNUMBER)
                {
                    throw new ArgumentException(nameof(Number), $"Number can't be greater than {MAXNUMBER}");
                }
                if(value < MINNUMBER)
                {
                    throw new ArgumentException(nameof(Number), $"Number can't be less than {MINNUMBER}");
                }
                _number = value;
            }
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank");
                }
                _name = value.Trim();
            }
        }

        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            protected set
            {
                if(!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException(nameof(GamesPlayed), "Games played must be greater than or equal to 0");
                }
                _gamesPlayed = value;
            }
        }

        public int Goals
        {
            get { return _goals; }
            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException(nameof(Goals), "Goals must be greater than or equal to 0");
                }
                _goals = value;
            }
        }

        public int Assists
        {
            get { return _assists; }
            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException(nameof(GamesPlayed), "Assists must be greater then or equal to 0");
                }
                _assists = value;
            }
        }

        public int Points => Goals + Assists;

        public Player(int number, string name, Position position)
        {
            Number = number;
            Name = name;
            Position = position;
        }

        public Player(int number, string name, Position position, int gamesPlayed, int goals, int assists)
        {
            Number = number;
            Name = name;
            Position = position;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
        }

        public void AddGamesPlayed()
        {
            GamesPlayed++;
        }

        public void AddGoal()
        {
            Goals++;
        }

        public void AddAssist()
        {
            Assists++;
        }
    }
}

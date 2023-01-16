using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemClassLibrary
{
    public class Player
    {
        private int _number;
        private string _name;
        private int _gamesPlayed;
        private int _goals;
        private int _assists;
        private int _points;

        public  Position Position { get; set; }

        public int Number
        {
            get { return _number; }
            set
            {
                if(value >= 99)
                {
                    throw new ArgumentNullException(nameof(Number), "Number cant be 99 or greater");
                }
                if(value <= 0)
                {
                    throw new ArgumentNullException(nameof(Number), "Number cant be less then or equal to 0");
                }
                _number = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank");
                }
                if (!value.Trim().All(char.IsLetter))
                {
                    throw new ArgumentNullException(nameof(Name), "Name can only contain letters a-z");
                }
                _name = value.Trim();
            }
        }

        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentNullException(nameof(GamesPlayed), "Games played must be greater then or equal to 0");
                }
                _gamesPlayed = value;
            }
        }

        public int Goals
        {
            get { return _goals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException(nameof(Goals), "Goals must be greater then or equal to 0");
                }
                _goals = value;
            }
        }

        public int Assists
        {
            get { return _assists; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException(nameof(GamesPlayed), "Assists must be greater then or equal to 0");
                }
                _assists = value;
            }
        }

        public int Points
        {
            get { return _points; }
            set
            {
                _points = Goals + Assists;
            }
        }

        public Player(int number, string name, int gamesPlayed, int goals, int assists, int points, Position position)
        {
            Number = number;
            Name = name;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
            Points = points;
            Position = position;
        }

        public void AddGoal(int number)
        {

        }

        public void AddAssist(int number)
        {

        }
    }
}

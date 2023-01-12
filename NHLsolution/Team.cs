namespace NHLsolution
{
    public class Team
    {
        private string _name;
        private string _city;
        private string _arena;
        private Conference _conference;
        private Division _division;

        public Team (string name, string city, string arena, Conference conference, Division division)
        {
            Name = name;
            City = city;
            Arena = arena;
            Conference = conference;
            Division = division;
        }

        public Team (string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                //not blank and only a-z
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input for Name");
                }
                else if (!value.All(char.IsLetter))
                {
                    throw new ArgumentNullException("Invalid input for Name");
                }
                else
                {
                    _name = value.Trim();
                }
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                //not blank must contain at least 3 letters
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input for City");
                }
                else if(value.Length < 3)
                {
                    throw new ArgumentNullException("Invalid input for City");
                }
                else
                {
                    _city = value;
                }
            }
        }

        public string Arena
        {
            get { return _arena; }
            set
            {
                //not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input for arena");
                }
                else
                {
                    _arena = value;
                }
            }
        }

        public Conference Conference { get; set; }
        public Division Division { get; set; }
    }
}
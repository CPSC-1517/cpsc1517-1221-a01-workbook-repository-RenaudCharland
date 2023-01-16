namespace NHLSystemClassLibrary
{
    public class Team
    {
        // Define fully implemented properties with a backing field for: Name, City, Arena
        private string _name;
        private string _city;
        private string _arena;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Validate new value is not blank and contains only letters a-z
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank.");
                }
                //validate new alue contains only letters a-z
                if (!value.Trim().All(i => char.IsLetter(i) || char.IsWhiteSpace(i)))
                {
                    throw new ArgumentNullException(nameof(Name), "Name can only contain letters a-z");
                }
                _name = value.Trim();   // remove leading "   hello" and trailing "hello    " white spaces
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                //verify that new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(City), "City cannot be blank.");
                }
                //Verify that new value contains 3 or more characters
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentNullException(nameof(City), "City must contain 3 or more characters");
                }
                _city = value.Trim();
            }
        }

        public string Arena
        {
            get { return _arena; }
            set
            {
                //validate that new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Arena), "Arena value cannot be blank");
                }
                _arena = value.Trim();
            }
        }

        // Define auto-implemented properties for: Conference, Division
        public Conference Conference { get; set; }
        public Division Division { get; set; }


        // Greedy constructor
        public Team(string name, string city, string arena, Conference conference, Division division)
        {
            Name = name;
            City = city;
            Arena = arena;
            Conference = conference;
            Division = division;
        }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, Arena: {Arena}, Conference: {Conference}, Division: {Division}";
        }
    }
}
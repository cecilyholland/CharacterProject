namespace CPSC3130_Project
{
    public class Character
    {
        String _name;
        String _gender;
        String _alignment;
        String _race;
        int _age;
        int _weight;
        String _height;
        Random random = new Random();
        public Character()
        {
            this._name = SetName();
            this._gender = SetGender();
            this._alignment = SetAlignmnet();
            this._race = SetRace();
            SetBiometric();
        }
        public String[] GetName()
        {
            String[] aName = { "Name", this._name };
            return aName;
        }
        public String[] GetGender()
        {
            String[] aGender = { "Gender", Convert.ToString(this._gender) };
            return aGender;
        }
        public String[] GetAlignment()
        {
            String[] aAlignment = { "Alignment", this._alignment };
            return aAlignment;
        }
        public String[] GetRace()
        {
            String[] aRace = { "Race", this._race };
            return aRace;
        }
        public String GetCharRace()
        {
            return this._race;
        }
        public String[] GetAge()
        {
            String[] aAge = { "Age", Convert.ToString(_age) };
            return aAge;
        }
        public String[] GetWeight()
        {
            String[] aWeight = { "Weight", $"{Convert.ToString(_weight)}lbs" };
            return aWeight;
        }
        public String[] GetHeight()
        {
            String[] aHeight = { "Height", _height };
            return aHeight;
        }

        public void DisplayCharacter()
        {

            Console.WriteLine($"\n*******{this._name}*******");
            Console.WriteLine($"Gender:    {this._gender}");
            Console.WriteLine($"Age:       {this._age}");
            Console.WriteLine($"Alignment: {this._alignment}");
            Console.WriteLine($"Race:      {this._race}");
            Console.WriteLine($"Height:    {this._height}");
            Console.WriteLine($"Weight:    {this._weight}");
        }


        //Method to set name for character
        public String SetName()
        {
            Console.Write("Choose your character name: ");
            String charName = Console.ReadLine();
            return charName;
        }

        //Method to set gender for character
        public String SetGender()
        {
            String gender = "Male";
            bool genderMenu = true;
            while (genderMenu)
            {
                Console.WriteLine("1. Male ");
                Console.WriteLine("2. Female");
                Console.Write("Your gender: ");
                String userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        {
                            gender = "Male";
                            genderMenu = false;
                            Console.WriteLine("Male");
                            break;
                        }
                    case "2":
                        {
                            gender = "Female";
                            genderMenu = false;
                            Console.WriteLine("Female");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose 1 for Male and 2 for Female.");
                            break;
                        }
                }
            }
            return gender;
        }
        public String SetAlignmnet()
        {
            String alignment = "";
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("1. Lawful Good");
                Console.WriteLine("2. Lawful Evil");
                Console.WriteLine("3. Neutral Good");
                Console.WriteLine("4. Neutral Evil");
                Console.WriteLine("5. Chaotic Good");
                Console.WriteLine("6. Chaotic Evil");
                Console.Write("Your Alignment: ");
                String userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        {
                            alignment = "Lawful Good";
                            menu = false;
                            Console.WriteLine("Lawful Good");
                            break;
                        }
                    case "2":
                        {
                            alignment = "Lawful Evil";
                            menu = false;
                            Console.WriteLine("Lawful Evil");
                            break;
                        }
                    case "3":
                        {
                            alignment = "Neutral Good";
                            menu = false;
                            Console.WriteLine("Neutral Good");
                            break;
                        }
                    case "4":
                        {
                            alignment = "Neutral Evil";
                            menu = false;
                            Console.WriteLine("Neutral Evil");
                            break;
                        }
                    case "5":
                        {
                            alignment = "Chaotic Good";
                            menu = false;
                            Console.WriteLine("Chaotic Good");
                            break;
                        }
                    case "6":
                        {
                            alignment = "Chaotic Evil";
                            menu = false;
                            Console.WriteLine("Chaotic Evil");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose between 1-6.");
                            break;
                        }
                }
            }
            return alignment;
        }
        //End of Alignment Method

        //Method to set Race for character
        public String SetRace()
        {
            String race = "";
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("1. Human");
                Console.WriteLine("2. Elf");
                Console.WriteLine("3. Dwarf");
                Console.WriteLine("4. Gnome");
                Console.WriteLine("5. Halfling");
                Console.Write("Your Race: ");
                String userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        {
                            race = "Human";
                            menu = false;
                            Console.WriteLine("Human race");
                            break;
                        }
                    case "2":
                        {
                            race = "Elf";
                            menu = false;
                            Console.WriteLine("Elf race");
                            break;
                        }
                    case "3":
                        {
                            race = "Dwarf";
                            menu = false;
                            Console.WriteLine("Dwarf race");
                            break;
                        }
                    case "4":
                        {
                            race = "Gnome";
                            menu = false;
                            Console.WriteLine("Gnome race");
                            break;
                        }
                    case "5":
                        {
                            race = "Halfling";
                            menu = false;
                            Console.WriteLine("Halfling race");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose between 1-5.");
                            break;
                        }
                }
            }
            return race;
        }
        public void SetBiometric()
        {
            int height = 0;
            int heightFeet = 0;
            int heightInches = 0;
            if (_race.Equals("Human"))
            {
                this._age = random.Next(15, 31);
                if (_gender.Equals("Male"))
                {
                    this._weight = random.Next(90, 261);
                    height = random.Next(54, 90);
                }
                else
                {
                    this._weight = random.Next(75, 201);
                    height = random.Next(52, 80);
                }
            }
            if (_race.Equals("Elf"))
            {
                this._age = random.Next(80, 181);
                if (_gender.Equals("Male"))
                {
                    this._weight = random.Next(70, 131);
                    height = random.Next(48, 67);
                }
                else
                {
                    this._weight = random.Next(65, 101);
                    height = random.Next(44, 65);
                }
            }
            if (_race.Equals("Dwarf"))
            {
                this._age = random.Next(40, 71);
                if (_gender.Equals("Male"))
                {
                    this._weight = random.Next(150, 231);
                    height = random.Next(48, 59);
                }
                else
                {
                    this._weight = random.Next(125, 181);
                    height = random.Next(44, 56);
                }
            }
            if (_race.Equals("Gnome"))
            {
                this._age = random.Next(30, 61);
                if (_gender.Equals("Male"))
                {
                    this._weight = random.Next(40, 61);
                    height = random.Next(30, 42);
                }
                else
                {
                    this._weight = random.Next(35, 56);
                    height = random.Next(28, 40);
                }
            }
            if (_race.Equals("Halfling"))
            {
                this._age = random.Next(30, 51);
                if (_gender.Equals("Male"))
                {
                    this._weight = random.Next(55, 81);
                    height = random.Next(38, 53);
                }
                else
                {
                    this._weight = random.Next(45, 71);
                    height = random.Next(35, 50);
                }
            }
            heightFeet = (int)(height / 12);
            heightInches = height % 12;
            this._height = $"{Convert.ToString(heightFeet)}'{Convert.ToString(heightInches)}\"";
        }
    }
}

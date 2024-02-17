using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    internal class CharacterChoice
    {
        // Instance variables
        private string _name;
        private string _gender;
        private string _alignment;
        private string _race;
        private int _age;
        private double _height;
        private int _weight;
        // Getters and setters for instance variables
        public string Name
        {
            get { return _name; }
            set { _name = Name; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = Gender; }
        }

        public string Alignment
        {
            get { return _alignment; }
            set { _alignment = Alignment; }
        }

        public string Race
        {
            get { return _race; }
            set { _race = Race; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = Age; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = Height; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = Weight; }
        }
        // Constructor
        public CharacterChoice(string name, string gender, string alignment, string race)
        {
            Name = name;
            Gender = gender;
            Alignment = alignment;
            Race = race;     
        }
        // Calculate age, height, and weight based on race
        private void CalculateAgeHeightWeight(string race)
        {
            Random random = new Random();
            switch (race)
            {
                case "Human":
                    _age = random.Next(15, 31);
                    if (_gender == "M")
                        _height = random.Next(54, 90);
                    else
                        _height = random.Next(52, 80);
                    if (_gender == "M")
                        _weight = random.Next(90, 261);
                    else
                        _weight = random.Next(75, 201);
                    break;
                case "Elf":
                    _age = random.Next(80, 181);
                    if (_gender == "M")
                        _height = random.Next(48, 67);
                    else
                        _height = random.Next(44, 65);
                    if (_gender == "M")
                        _weight = random.Next(70, 131);
                    else
                        _weight = random.Next(65, 101);
                    break;
                case "Dwarf":
                    _age = random.Next(40, 71);
                    if (_gender == "M")
                        _height = random.Next(48, 50);
                    else
                        _height = random.Next(45, 57);
                    if (_gender == "M")
                        _weight = random.Next(150, 231);
                    else
                        _weight = random.Next(125, 181);
                    break;
                case "Gnome":
                    _age = random.Next(30, 61);
                    if (_gender == "M")
                        _height = random.Next(31, 43);
                    else
                        _height = random.Next(28, 40);
                    if (_gender == "M")
                        _weight = random.Next(40, 61);
                    else
                        _weight = random.Next(35, 56);
                    break;
                case "Halfing":
                    _age = random.Next(30, 51);
                    if (_gender == "M")
                        _height = random.Next(38, 52);
                    else
                        _height = random.Next(25, 50);
                    if (_gender == "M")
                        _weight = random.Next(55, 81);
                    else
                        _weight = random.Next(45, 71);
                    break;
            }
        }
    }
}

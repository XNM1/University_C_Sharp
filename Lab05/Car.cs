using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab05
{
    class Car
    {
        #region fields
        private double weight;
        private string number;
        private int speed;
        private int maxSpeed;
        #endregion

        #region Properties
        public int MaxSpeed
        {
            get { return maxSpeed; }
            private set
            {
                if (value > 0)
                    maxSpeed = value;
                else
                    throw new InvalidSpeedException();
            }
        }
        public int Speed {
            get { return speed; }
            set
            {
                if (value >= 0)
                    speed = value;
                else
                    throw new InvalidSpeedException();
            }
        }

        public string Color { get; set; }

        public AutoModel Model { get; private set; }

        public double Weight {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    throw new InvalidWeightException();
            }
        }

        public string Number {
            get { return number; }
            set
            {
                switch (Country)
                {
                    case Countries.Ukarine:
                        if (Regex.IsMatch(value, "^[A-Z]{2}[0-9]{4}[A-Z]{2}$"))
                            number = value;
                        else
                            throw new InvalidNumberException(Country);
                        break;
                    case Countries.Russia:
                        if (Regex.IsMatch(value, "^[A-Z]{1}[0-9]{3}[A-Z]{2}[0-9]{2}$"))
                            number = value;
                        else
                            throw new InvalidNumberException(Country);
                        break;
                    case Countries.USA:
                        if (Regex.IsMatch(value, "^[A-Z 0-9]{7}$"))
                            number = value;
                        else
                            throw new InvalidNumberException(Country);
                        break;
                }
            }
        }

        public Countries Country { get; private set; }
        #endregion

        #region Constructors
        public Car(Countries country, string number, AutoModel model, double weight, int maxSpeed)
        {
            Country = country;
            Number = number;
            Weight = weight;
            Model = model;
            MaxSpeed = maxSpeed;
        }
        #endregion

        #region Enums
        public enum Countries
        {
            Ukarine,
            Russia,
            USA
        }

        public enum AutoModel
        {
            Audi,
            Mersedes,
            Mitsubisy,
            Chevrolet,
            Lada,
            Hundai,
            Reno,
            Mazda
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Model: " + Model.ToString() + "| Number: " + Number.ToString()
                + "| Country: " + Country.ToString() + "| Weigth: " + Weight.ToString()
                + "| Max Speed: " + MaxSpeed.ToString();
        }
        #endregion

        #region Exceptions
        public class CarException : Exception 
        {
            public CarException(string messange) : base(messange) { }
        }
        public class InvalidWeightException : CarException
        {
            public InvalidWeightException() : base("Invalid weight input") { }
        }
        public class InvalidNumberException : CarException
        {
            public Countries CountryFormat { get; private set; }
            public InvalidNumberException(Countries countryFromat) : base("Invalid number input") 
            {
                CountryFormat = countryFromat;
            }
        }
        public class InvalidSpeedException : CarException
        {
            public InvalidSpeedException() : base("Invalid speed input") { }
        }
        #endregion
    }
}

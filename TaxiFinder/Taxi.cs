﻿using System;

namespace TaxiFinder
{
    [Serializable]
    public class Taxi
    {
        public Taxi()
        {
            Brand = Model = Color = Class = Driver = Number = string.Empty;
        }

        // set property is public to allow serialization
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
        public string Driver { get; set; }
        public string Number { get; set; }

        public bool IsAllFieldsInitialized()
        {
            return Brand != string.Empty && Model != string.Empty && Color != string.Empty &&
                   Class != string.Empty && Driver != string.Empty && Number != string.Empty;
        }

        public bool IsAllFieldsBlank()
        {
            return Brand == string.Empty && Model == string.Empty && Color == string.Empty &&
                   Class == string.Empty && Driver == string.Empty && Number == string.Empty;
        }
    }
}
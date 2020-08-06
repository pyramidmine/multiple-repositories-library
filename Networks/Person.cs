using System;
using System.Diagnostics;

namespace MannaPlanet.Networks
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string GetInfo()
        {
            Debug.WriteLineIf(Age <= 0, $"{Name}'s age is 0.");
            return string.Format($"{Name} is {Age} years old.");
        }
    }
}

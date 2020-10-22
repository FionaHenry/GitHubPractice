using System;

namespace polymorphism
{
    class Animal
    {
        public void MakeAnimalSound()
        {
            Console.WriteLine("I MAKE NOISES!!!");
        }
    }

    class Cat : Animal
    {
        public void MakeAnimalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
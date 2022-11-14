using System;

namespace StaticPublicPrivate
{
    class Bird
    {
        //we can ask the constructor method to Squawk
        //because Bird is a Bird and it can Squawk as it has access to the behavior within the Bird class but louie the object cannot
        public Bird()
        {
            Squawk();
        }
        //behavior 
        //considered private and only accessible within the class. Only other instances of this class can access behaviors in this class Bird
        //In other words, other Bird methods can access this method but not other classes
        //Solution: make Squawk() public
        public void Squawk()
        {
            Console.WriteLine("Squawk");
        }
        //why would we use private methods?
        //to hide the implementation details of a method from the outside world
    }
    class Program
    {//static means that the method Main can be call without an instance of the class Program
        static void Main(string[] args)
        {
            var louie = new Bird();
            louie.Squawk();//louie, the object performs its behavior or method Squawk
            Console.WriteLine("Static Public Private");

        }
    }

    //there is also protected access modifier
}

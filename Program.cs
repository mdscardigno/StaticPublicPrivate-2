using System;

namespace StaticPublicPrivate
{
    class Math
    {
        static public double Pi()
        {
            return 3.1415926535897932384626433832795;
        }
    }
    class Bird
    {
        public string Name { get; set; }

        //we can ask the constructor method to Squawk
        //because Bird is a Bird and it can Squawk as it has access to the behavior within the Bird class but louie the object cannot
        //Constructor of the class
        //IS a Bird
        public Bird() //instance method
        {
            Squawk();
        }
        //behavior 
        //considered private and only accessible within the class. Only other instances of this class can access behaviors in this class Bird
        //In other words, other Bird methods can access this method but not other classes
        //Solution: make Squawk() public
        //Is a Bird
        public void Squawk()
        {
            //we need an instance for this method to work
            Console.WriteLine($"{Name} says Squawk!");//this is a string interpolation
            if (AreTheyAwesome())
            {
                Console.WriteLine("They are awesome!");
            }

        }
        //static methods can call other static methods
        //a static method cannot call a non-static method (instance methods)
        //instance methods can call other instance methods and static methods
        //static can static
        //static cannot instance
        //instance can static and instance
        //everybody can call static methods
        //static methods cant call instance methods unless they make a new Bird(). see line: 57

        //behavior
        //related to Bird but not one instance of Bird
        //for static, I am defining a method in the class itself and not in the instance of the class
        //This method is not *A* Bird, it is the Bird class itself. In other languages we call them class methods
        //This is not for an specific bird but for the concept of a bird / birds in general
        static public Boolean AreTheyAwesome()
        {
            //instance methods: object.method()
            //static methods: className.method()
            var bird = new Bird();
            bird.Squawk(); //this bird Squawks (instance)
            return true;
        }

        //why would we use private methods?
        //to hide the implementation details of a method from the outside world
    }
    class Program
    {//static means that the method Main can be call without an instance of the class Program
        static void Main(string[] args)
        {
            var louie = new Bird();
            //louie.Squawk(); is an instance of the bird
            louie.Squawk();//louie, the object performs its behavior or method Squawk
                           //In order to have methods we have to have a class
            Bird.AreTheyAwesome();//So I can call the method AreTheyAwesome on the class Bird not on an instance of a Bird
            // louie.AreTheyAwesome();//louie, the object performs its behavior or method AreTheyAwesome
            Console.WriteLine("Static Public Private");

            var pizza = 2 * Math.Pi() * 16;//I do not need to make a new instance of the class Math, I can call the method Pi() on the class Math
            //static methods are used when we do not need to make a new whatever to be able to call a method

        }
    }

    //there is also protected access modifier
}

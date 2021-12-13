using System;
namespace abstraction
{
    abstract class animal
    {
        public abstract void animalsound(); //abstract method with out body
        public void sleep() // regular method
        {
            Console.WriteLine("sleep sound is zzz");
        }
    }
    class dog : animal
    {
        public override void animalsound()
        { 
            Console.WriteLine("the dog say:bow,bow");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            dog obj1 = new dog();
            obj1.animalsound();
            obj1.sleep();
            
        }
    }
}
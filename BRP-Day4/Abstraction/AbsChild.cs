using System;

namespace Abstraction
{
    class AbsChild : AbsParent
    {
        public override void Product(int number1, int number2)
        {
            Console.WriteLine("Product is : " + (number1 * number2));
        }
        public override void Division(int number1, int number2)
        {
            Console.WriteLine("Division is : " + (number1 / number2));
        }

        static void Main()
        {
            AbsChild obj = new AbsChild();
            obj.Product(10, 50);
            obj.Division(100, 20);
            obj.Subtract(100, 50);
            obj.Add(100, 50);
        }
    }
    abstract class AbsParent
    {
        public void Add(int number1, int number2)
        {
            Console.WriteLine("Sum is : " + (number1 + number2));
        }
        public void Subtract(int number1, int number2)
        {
            Console.WriteLine("Difference is : " + (number1 - number2));
        }
        public abstract void Product(int number1, int number2);
        public abstract void Division(int number1, int number2);
    }
}
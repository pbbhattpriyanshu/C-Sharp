namespace Interview
{
    internal class Program
    {
        static void Greet(string name) //Parameter
        {
            Console.WriteLine("Good morning " + name );
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Calc(int number)
        {
            Console.WriteLine("Square: " + number * number);
        }

        static void CheckN(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            } else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Interview Practice");
            string name = "Piyush";
            int age = 22;
            string college = "GN Group";
            double CGPA = 7.1;
            bool isPlaced = false;

            Console.WriteLine(10.0/3);

            int x = 10;
            x += 5; //x = x + 5
            x -= 2; //x = x - 2
            x *= 2;
            x /= 3;

            // ==, <, >, >=, <=, != - Comparison op
            Console.WriteLine(age != 20); //true -- boolean
            Console.WriteLine(age > 25); //false

            // AND && (both st must be true)
            bool hasLincense = false;
            if (age >= 18 && hasLincense)
            {
                Console.WriteLine("Can Drive");
            } else
            {
                Console.WriteLine("Can Not Drive");
            }
            // OR || (only 1 st must be true)
            if (age >= 18 || hasLincense)
            {
                Console.WriteLine("Can Drive");
            }
            else
            {
                Console.WriteLine("Can Not Drive");
            }
            // NOT ! (reverse the decision )
            Console.WriteLine(!hasLincense);

            string[] names = { "Aman", "Maynk", "puish" };
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }

            Greet("Mikasa"); //Arguments
            Greet("goku");
            Greet("ash");
            Greet("gojo");
            Greet("yuta");

            Console.WriteLine(Add(2, 3));

            int num1 = 100;
            int num2 = 45;
            int num3 = 23;

            int largest;

            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            } else if (num2  >= num3 && num2 >= num1)
            {
                largest = num2;
            } else
            {
                largest = num3;
            }

            Console.WriteLine(largest);
            Calc(6);
            CheckN(9);

            //Class and Object
            Student student1 = new Student("Puish", 18, "Science", "Cricket", 2026);
            student1.hobby = "Football";
            Student student2 = new Student("Aman", 17, "Commerce", "football", 2026);

            student1.DisplayInfo();
            student2.DisplayInfo();

            Car car1 = new Car("Toyota", "Fortuner", 45000000);
            car1.DisplayInfo();

            Bank acc1 = new Bank();
            acc1.balance = 13234;
            acc1.CheckBal();

            Developer dev = new Developer("Priyanshu");
            dev.name = "Priyanshu";
            dev.Work();
            dev.Code();
            dev.Location();

            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(10, 20));
            Console.WriteLine(cal.Add(10, 20, 30));
            Console.WriteLine(cal.Add(10.5, 20.5));

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Sound();
            cat.Sound();
        }
    }
}

using System;

namespace GenericCollections
{
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework - Fibonucci
            //Fibonacci fibonacci = new Fibonacci();
            //fibonacci.Fibonation(10);
            #endregion

            #region Implicit, Excplicit

            //Manat manat = new Manat(340);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.USD);

            #endregion

            #region Generic

            //StringList strs = new StringList();
            //strs.Add("Emin");
            //strs.Add("Esger");
            //strs.Add("Seid");
            //strs.Add("Ferhad");
            //strs.GetAll();

            //IntList list = new IntList();
            //list.Add(2);
            //list.Add(4);
            //list.Add(6);
            //list.GetAll();

            //PersonList personlist = new PersonList();
            //personlist.Add(new Person { Age = 33 });
            //personlist.Add(new Person { Age = 36 });
            //personlist.Add(new Person { Age = 45 });
            //personlist.GetAll();

            //DataList<string> strs= new DataList<string>();
            //strs.Add("Esger");
            //strs.Add("Erestun");
            //strs.Add("Rovshen");
            //strs.GetAll();

            //DataList<int> nums = new DataList<int>();
            //nums.Add(100);
            //nums.Add(110);
            //nums.Add(190);
            //nums.GetAll();

            //DataList<Person> people = new DataList<Person>();
            //people.Add(new Person { Age = 11 });
            //people.Add(new Person { Age = 21 });



            #endregion

            #region Operator overloading

            //Employee employee = new Employee(18, "Erestun", "Ekberli");
            //Student student = new Student(22, "Emin", "Kazim");
            //Console.WriteLine(employee > student);

            #endregion

            #region 14.12.2021 - Homework

            Person<int> person = new Person<int>();

            person.Add(22);
            person.Add(24);
            person.Add(26);

            person.GetAll();

            #endregion
        }
    }

    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }

        public Employee(int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }

        public static bool operator > (Employee employee, Student student)
        {
            return employee.Age > student.Age;
        }

        public static bool operator < (Employee employee, Student student)
        {
            return employee.Age < student.Age;
        }
    }

    #region 14.12.2021 - Homework
    class Person<T>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private T[] arr;

        public Person()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Array.Sort(arr);
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion

    //class DataList<T>
    //{
    //    private T[] arr;

    //    public DataList()
    //    {
    //        arr = new T[0];
    //    }

    //    public void Add(T data)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = data;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class StringList
    //{
    //    private string[] arr;

    //    public StringList()
    //    {
    //        arr = new string[0];
    //    }

    //    public void Add(string str)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = str;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class IntList
    //{
    //    private int[] arr;

    //    public IntList()
    //    {
    //        arr = new int[0];
    //    }

    //    public void Add(int n)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = n;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class PersonList
    //{
    //    private Person[] arr;

    //    public PersonList()
    //    {
    //        arr = new Person[0];
    //    }

    //    public void Add(Person person)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = person;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item.Age);
    //        }
    //    }
    //}

    //class Person
    //{
    //    public int Age { get; set; }
    //}

    //class Dollar
    //{
    //    public double USD { get; set; }

    //    public Dollar(double usd)
    //    {
    //        USD = usd;
    //    }
    //}

    //class Manat
    //{
    //    public double AZN { get; set; }

    //    public Manat(double azn)
    //    {
    //        AZN = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.AZN / 1.7);
    //    }
    //}
}

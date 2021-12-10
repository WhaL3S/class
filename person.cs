class Person
    {
        private double height,
                       weight;
        private string name;
        public Person(string name, double height, double weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }
        public string GetPersonName() { return name; }
        public double GetPersonHeight() { return height; }
        public double GetPersonWeight() { return weight; }
        public void PrintData(Person p)
        {
            Console.WriteLine("{0} has height of {1} and weight of {2}", p.GetPersonName(), p.GetPersonHeight(), p.GetPersonWeight());
        }
        public static double lowest_height_finding(double[] height_comparison, double lowest_height)
        {
            for (int i = 0; i < 4; i++)
            {
                if (height_comparison[i] < lowest_height)
                {
                    lowest_height = height_comparison[i];
                }
            }
            return lowest_height;
        }
        public void is_lowest(Person p, double lowest_height)
        {
            if (p.GetPersonHeight() == lowest_height)
            {
                Console.WriteLine(p.GetPersonName());
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person("John", 175, 67);
            Person p2 = new Person("Mark", 180, 78);
            Person p3 = new Person("Toby", 175, 75);
            Person p4 = new Person("Anthony", 178, 70);

            p1.PrintData(p1);
            p2.PrintData(p2);
            p3.PrintData(p3);
            p4.PrintData(p4);

            Console.WriteLine("");

            double average_weight, lowest_height = 1000;
            double[] height_comparison = { p1.GetPersonHeight(), p2.GetPersonHeight(), p3.GetPersonHeight(), p4.GetPersonHeight() };
            average_weight = (p1.GetPersonWeight() + p2.GetPersonWeight() + p3.GetPersonWeight() + p4.GetPersonWeight()) / 4;

            lowest_height = lowest_height_finding(height_comparison, lowest_height);

            Console.WriteLine("The lowest person(s) is(are):");
            p1.is_lowest(p1, lowest_height);
            p2.is_lowest(p2, lowest_height);
            p3.is_lowest(p3, lowest_height);
            p4.is_lowest(p4, lowest_height);
            Console.WriteLine("\nThe average weight is " + average_weight);
        }
    }

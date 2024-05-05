namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Employee> employees = new List<Employee>();

           while (true) 
            {
                Console.WriteLine("1-Student elave et");



                Console.WriteLine("2-Employe elave  et");

                Console.WriteLine("3-Axtarış et");

                Console.WriteLine("4-Çıxış Menusu");


                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        {
                            AddStudents(students);
                            break;
                        }
                    case "2":
                        {
                            AddEmployee(employees);
                            int secim = int.Parse(Console.ReadLine());
                            if (secim == 1) 
                            {
                                Console.WriteLine("Vezifeni yaz: ");
                                string poz = Console.ReadLine();
                                foreach (Employee e in employees.FindAll(x => x.Position == poz))
                                {
                                    Console.WriteLine(e.Name);
                                }
                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Sinif araligini yaz");
                                int grademin = int.Parse(Console.ReadLine());
                                int grademax =  int.Parse(Console.ReadLine());
                                foreach (Student d in students.FindAll(x => x.Grade > grademin && x.Grade < grademax))
                                {
                                    Console.WriteLine(d.Name);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Duzgun eded daxil edin");
                            }
                            break;
                        }
                            
                                
                        
                    case "3":
                        {
                            SearchMenu(students, employees);
                            break;
                        }
                    case "4":
                        {
                            Environment.Exit(0);
                            Console.WriteLine("Secim duzgun deyil");
                            break;
                        }

                }


            }


            static void AddEmployee(List<Employee> employees)
            {
                Console.WriteLine("Ad:");
                string name = Console.ReadLine();
                Console.WriteLine("Soyad: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Yas: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Pozisiya: ");
                string position = Console.ReadLine();
            }

            static void AddStudents(List<Student> students)
            {
                Console.WriteLine("Ad:");
                string name = Console.ReadLine();
                Console.WriteLine("Soyad: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Yas: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Sinif:");
                int grade = int.Parse(Console.ReadLine());
            }

            static void SearchMenu(List<Student> students, List<Employee> employees)
            {
                Console.WriteLine("1-Employe uzre axtaris");
                Console.WriteLine("2-Student uzre axtaris");
                Console.WriteLine("3-Menuya geri qayidis");

                string choise =     Console.ReadLine();
                
                switch (choise)
                {
                    case "1":
                        SearchEmployee(employees);
                        break;
                    case "2":
                        SearchStudent(students);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edilmedi.");
                        break;
                }
            }
            static void SearchEmployee (List<Employee> employees)
            {
                Console.Write("Vezife: ");
                string position = Console.ReadLine();

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }

            static void SearchStudent(List<Student> students)
            {
                Console.Write("minGrade: ");
                string minGrade = Console.ReadLine();
                Console.Write("maxGrade: ");
                string maxGrade = Console.ReadLine();


                foreach (Student student in students)
                {
                    Console.WriteLine(student);
             
                }
            }

        }

    }
}

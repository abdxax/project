using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();
            while (true)
            {
                Console.WriteLine("1-Add new Item \t 2-search \t 3-exit");
                int item = int.Parse(Console.ReadLine());
                switch (item)
                {
                    case 1:
                        Console.WriteLine("ID");
                        int id= int.Parse(Console.ReadLine());
                        Console.WriteLine("Class");
                        String clas = Console.ReadLine();
                        Console.WriteLine("Section");
                        String sec= Console.ReadLine();
                        schools.Add(new School(id, clas, sec));
                        break;
                    case 2:
                        Console.WriteLine("ID");
                        int ids = int.Parse(Console.ReadLine());
                        var status = false;
                        foreach(School s in schools)
                        {
                            if (s.ID == ids)
                            {
                                Console.WriteLine("Class " + s.Class);
                                Console.WriteLine("Class " + s.Section);
                                status = true;
                                break;
                            }
                          
                        }
                        if (status == false)
                        {
                            Console.WriteLine("Nothing");
                        }

                        break;
                    
                }
                if (item == 3)
                {
                    break;
                }
                
            }
            Console.WriteLine("Hello World!");

        }
    }
}

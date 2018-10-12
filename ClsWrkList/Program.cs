using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10];

            //List<int> list = new List<int>();

            //for (int i = 0; i < 50; i++)
            //{
            //    list.Add(i);
            //}

            //int j = 0;
            //foreach (var lis in list)
            //{
            //    Console.WriteLine($"List[{j}]- {lis}");
            //    j++;
            //}

            //// Contain : check the existence of value inside list ...................................

            //bool contain = list.Contains(55);
            //Console.WriteLine(contain);//
         
            // list.Insert(4, 2000000000);

            //Console.WriteLine("After Insertion.............");
            //int k = 0;
            //foreach (var lis in list)
            //{
            //    Console.WriteLine($"List[{k}]- {lis}");
            //    k++;
            //}


            List<Student> list = new List<Student>();
            // Declare the List object with object data items 
           
            List<Student> listStudent = new List<Student>()
            {
                new Student(12345, "Name1"),
                new Student(56784, "Name2"),
                new Student(34567, "Name3"),
                new Student(1234, "Name4"),
                new Student(5656, "Name5"),
                new Student(76676, "Name6"),
                new Student(342343, "Name7"),
                new Student(8798, "Name8"),

            };

            // Display the data items 

            foreach (var lis in listStudent)
            {
                Console.WriteLine(listStudent);
                Console.WriteLine($"ID: {lis.ID} - Name: {lis.Name}");
            }
            //listStudent.Add( new Student(12345 , "Name1" ));
            //listStudent.Add(new Student(34565, "Name2"));
            //listStudent.Add(new Student(76684, "Name3"));

            List<Student> newSearchList  = new List<Student>();
            Console.WriteLine("Insert searching Id");
            string searchId = Console.ReadLine();
            while (searchId != null && searchId.ToUpper() != "STOP")
            {
                foreach (var lis in listStudent)
                {
                    Console.WriteLine("Search iterations.........");
                    if (lis.ID.ToString() == searchId)
                    {
                        Console.WriteLine("Search is Found");
                        newSearchList.Add(lis);
                    }
                }

                Console.WriteLine("Do you want to search the Item again");
                searchId = Console.ReadLine();

            }

            Console.WriteLine("While Loop is terminated");

            foreach (var searchFound in newSearchList)
            {
                Console.WriteLine("New search item found ");
                Console.WriteLine($"Name for new search Id : {searchFound.Name}");
            }

            Console.ReadKey();

            
        }
    }
}

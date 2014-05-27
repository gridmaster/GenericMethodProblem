using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericMethodProblem
{
    internal class Program
    {
        private static List<T> GetList<T>(IList<string> rows) where T : Models.MyBass, new()
        {
            List<T> myList = new List<T>();

            foreach (var row in rows)
            {
                string[] cols = StringWorks.GetColumns(row);

                var returnEx = new T();
                returnEx.LoadRow<T>(cols);
                myList.Add(returnEx);
            }

            return myList;
        }

        static void Main(string[] args)
        {
            IList<string> rows1 = new List<string>
                {
                    "400</td>, <td>500</td>", 
                    "\"four\"</td>, <td>\"five\"</td>", 
                    "\"shemp\"</td>, <td>\"joe\"</td>"
                };
            IList<string> rows2 = new List<string>
                {
                    "100</td>, <td>200</td>, <td>300</td>", 
                    "\"one\"</td>, <td>\"two\"</td>, <td>\"three\"</td>", 
                    "\"moe\"</td>, <td>\"larry\"</td>, <td>\"curly\"</td>"
                };
            
            var list1 = GetList<Models.ReturnEx1>(rows1);
            var list2 = GetList<Models.ReturnEx2>(rows2);

            Console.ReadKey();
        }
    }
}

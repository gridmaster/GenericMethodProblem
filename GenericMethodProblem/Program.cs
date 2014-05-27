using System;
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
                string[] cols = row.Split(',');

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
                    "400, 500", 
                    "\"four\", \"five\"", 
                    "\"shemp\", \"joe\""
                };
            IList<string> rows2 = new List<string>
                {
                    "100, 200, 300", 
                    "\"one\", \"two\", \"three\"", 
                    "\"moe\", \"larry\", \"curly\""
                };
            
            var list1 = GetList<Models.ReturnEx1>(rows1);
            var list2 = GetList<Models.ReturnEx2>(rows2);

            Console.ReadKey();
        }
    }
}

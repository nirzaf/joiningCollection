using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualBasic;

namespace app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var col1 = new Collection<Subject>();
            var col2 = new Collection<Subject>();

            var s = new Subject();
            s.ID = 32;
            s.Name = "Mahesh";
            s.Mark = 54;

            var s1 = new Subject();
            s.ID = 34;
            s.Name = "Nimal";
            s.Mark = 57;

            //Subject s3 = new Subject();
            //s.ID = 32;
            //s.Name = "Mahesh";
            //s.Mark = 54;

            var s3 = new Subject();
            s.ID = 43;
            s.Name = "Rohan";
            s.Mark = 56;

            col1.Add(s);
            col1.Add(s1);
            col2.Add(s);
            col2.Add(s3);

            for (var i = 0; i < col1.Count - 1; i++)
            for (var j = 0; j < col2.Count - 1; j++)
                if (col1[i].Name == col2[i].Name)
                    if (col1[i].Mark > 50)
                        Console.WriteLine(col1[i].Name);

            Console.WriteLine("Hello World!");
        }

        public class Subject
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Mark { get; set; }
        }
    }
}
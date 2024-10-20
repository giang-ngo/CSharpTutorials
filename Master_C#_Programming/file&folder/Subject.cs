using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    public class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public int NumOfLesson { get; set; }
        public string Type { get; set; }
        public int NumOfRegister { get; set; }

        public Subject(string id, string name, int credit, int numOfLesson, string type, int numOfRegister)
        {
            Id = id;
            Name = name;
            Credit = credit;
            NumOfLesson = numOfLesson;
            Type = type;
            NumOfRegister = numOfRegister;
        }

        public override string ToString()
        {
            return $"{Id,-10}{Name,-50}{Credit,-10}{NumOfLesson,-20}{Type,-20}{NumOfRegister,-20}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HW_Classes
{
    public class Stack
    {
        //поля
        //private List<string> stackList;
        private StackItem stackItemVar;

        //Конструктор
        public Stack(params string[] entries)
        {
            //stackList = new List<string>(entries);
            stackItemVar = new StackItem(entries);
            Console.WriteLine("создался stackitem");
        }

        //свойства
        //public int Size => stackList.Count;
        //public string Top => stackList[stackList.Count];
        public int? Size => stackItemVar.CountOfElem;
        public string? Top => stackItemVar.TopElem;

        //методы
        public string[]? Add(string extraElement) => stackItemVar.Add(extraElement);
        public string? Pop() => stackItemVar.Pop();
    }

}

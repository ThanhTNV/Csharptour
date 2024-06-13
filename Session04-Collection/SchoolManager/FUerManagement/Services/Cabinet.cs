using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManagement.Services
{
    public class Cabinet<T>
    {
        private List<T> _arr;
        public Cabinet()
        {
            _arr = new List<T>();//muốn nhiêu cho nhiêu, không cần xin
        }

        public void PrintItems()
        {
            if(_arr.Count > 0)
            {
                foreach(T item in _arr)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("BRO, YOU HAVEN'T ADDED ANYTHING INTO THE LIST YET!");
            }
            //Abstract - Inheritance - Encapsulation - Polymorphism
            //Encapsulation
            //Modularity
        }

        public void AddAnItem(T item) => _arr.Add(item);
    }
}

using FUerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Services
{
    internal class LecturerCabinet
    {
        private Lecturer[] _arr;
        private int _count = 0;
        public int Count { get; }
        public LecturerCabinet(int size) => _arr = new Lecturer[size];
        public void Add(Lecturer lecturer)
        {
            _arr[_count] = lecturer;
            _count++;
        }

        public void Print()
        {
            Console.WriteLine($"There is/are {_count} lecturer(s) in the cabinet");
            for (int i = 0; i < _count; i++)
            {
                _arr[i].ShowProfile();
            }
        }


    }
}

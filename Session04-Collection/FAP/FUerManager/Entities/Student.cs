﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FUerManager.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string? ToString() => $" ID: {Id} | Name: {Name} | Yob: {Yob} | GPA: {Gpa}";
        public void ShowProfile() => Console.WriteLine(ToString());
    }
}
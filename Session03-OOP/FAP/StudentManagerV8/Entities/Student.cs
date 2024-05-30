using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV8.Entities
{
	internal class Student
	{
		//propfull + tab

		private string _id;//Backing field
		//KỸ THUẬT THIẾT KẾ CLASS MÀ XÀI BACKING FIELD + PROPERTY GỌI LÀ: PROPFULL
		public string Id//Property
		{
			get => _id;
			set => _id = value;
		}
		private string _name;
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		private int _yob;
		public int Yob
		{
			get => _yob;
			set => _yob = value;
		}
		private double _gpa;
		public double Gpa
		{
			get => _gpa;
			set => _gpa = value;
		}

	}
}

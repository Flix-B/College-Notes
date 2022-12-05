using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Test
    {
        private string _firstname;
         get { return this._firstname; }
        public Test()
        {
            _firstname=string.Empty;
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public double areaOfRectangle(double height double width)
        {
            return height * width;
        }
    }
}

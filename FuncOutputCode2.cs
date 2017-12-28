using System;

namespace SoloLearn
{
    public class Person {

        private string name;
        public string Name { get { return "jon"; }}
    }


    public class FuncOutputCode2 : IFuncOutputCode
    {
        public void Main(){
            Person p = new Person();
            //p.Name = "bil"; //compilation error
            Console.Write(p.Name);

        }
    }
}
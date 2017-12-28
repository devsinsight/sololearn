using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        public static Dictionary<string, Type> func = 
        new Dictionary<string, Type>()
        {
            { "1", typeof(FuncOutputCode1) },
            { "2", typeof(FuncOutputCode2) }
        };


        static void Main(string[] args)
        {
           IFuncOutputCode result = (IFuncOutputCode)Activator.CreateInstance(func["1"]);
           result.Main();
        }
    }
}

using System;

namespace SoloLearn
{
    public class FuncOutputCode1 : IFuncOutputCode
    {
        public int Func(int a, int b, int c){
            return a * (c % b);
        }

        public void Main(){
            int x = 5;
            int y = 9;
            int z = 3;
            int f = Func(c: y, b: x, a: z);
            Console.WriteLine(f);
        }
    }
}
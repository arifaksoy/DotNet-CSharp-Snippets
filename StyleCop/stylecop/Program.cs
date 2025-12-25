using System;

namespace stylecop
{
    class program
    {
        public static void Main(string[] args)
        {
            var badexample = new badexample();
            badexample.printmessage();
            var goodexample = new GoodExample();
            goodexample.PrintMessage();
        }
    }
}

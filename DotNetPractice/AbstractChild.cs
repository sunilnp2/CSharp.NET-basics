using System;


namespace DotNetPractice
{
    public class AbstractChild:AbstractClass
    {
    public AbstractChild(int i,int j) {
            this.a = i;
            this.b = j;
        }

        public override int OutPut(int a,int b)
        {
            return a * b;
        }

    }
}

using System;
namespace PlayGround
{

    class Sample
    {
        public int func()
        {
            return 1;
        }
        public Single func()
        {
            return 2.4f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            int i;
            i = s1.func();
            Single j;
            j = s1.func();
        }
    }

    class Sample1
    {
        int i;
        Single j;
        double k;
        public Sample1(int ii, Single jj, double kk)
        {
            i = ii;
            j = jj;
            k = kk;
        }
    }
}

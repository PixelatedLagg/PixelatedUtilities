using System;
namespace PUtils.Number
{
    public class Rand
    {
        public Rand() {}
        public int this[int l, int h]
        {
            get
            {
                return new Random().Next(l, h + 1);
            }
        }
        public double this[double l, double h]
        {
            get
            {
                return new Random().NextDouble() + new Random().Next((int)l, (int)h + 1);
            }
        }
    }
}
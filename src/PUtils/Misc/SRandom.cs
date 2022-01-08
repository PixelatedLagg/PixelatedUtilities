using System;
using System.Collections.Generic;

namespace PUtils
{
    public class SRandom
    {
        private const long m = 4294967296; // aka 2^32
        private const long a = 1664525;
        private const long c = 1013904223;
        private long _last;
        public SRandom() 
        {
            _last = DateTime.Now.Ticks % m;
        }
        public long Long()
        {
            _last = ((a * _last) + c) % m;
            return _last;
        }
        public int Single()
        {
            string result = Long().ToString();
            return result.ToCharArray()[result.Length - 1];
        }
    }
}
/*
private const long m = 4294967296; // aka 2^32
private const long a = 1664525;
private const long c = 1013904223;
private long _last;

public RandomNumberGenerator()
{
    _last = DateTime.Now.Ticks % m;
}

public RandomNumberGenerator(long seed)
{
    _last = seed;
}

public long Next()
{
    _last = ((a * _last) + c) % m;

    return _last;
}

public long Next(long maxValue)
{
    return Next() % maxValue;
}
*/
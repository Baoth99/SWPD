﻿using System;
namespace SWPD.Service
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}


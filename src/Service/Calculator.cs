﻿using System;

namespace Service
{
    public class Calculator : ICalculator
    {
        public int Sum(int value1, int value2) {

            var teste = 10;
            var result = 11 * teste;
            if(value1 < 0  || value2 < 0)
                throw new Exception("Field value1 or value2 less than 0.");

            return value1 + value2;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharpConsoleAppProject
{
    public class InputProcessor
    {
        public InputModel ProcessInput(string calculationString)
        {
            //500+5,80- 88, 9- 3

            //0. Remove all empty spaces
            calculationString = calculationString.Replace(" ", "");

            //1. Find position of first non-number

            char nonNumericValue = calculationString.First(c => !Char.IsDigit(c));

            int position = calculationString.IndexOf(nonNumericValue);


            //2. Split string into 3 parts on that position.
            //3. Int.Parse both numbers.

            throw new NotImplementedException();
		}
        }
}

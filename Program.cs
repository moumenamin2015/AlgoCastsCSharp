﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoCastsCs.completedExcersices.ArrayChunk;
using AlgoCastsCs.completedExcersices.FizzBuzz;
using AlgoCastsCs.completedExcersices.Maxchar;
using AlgoCastsCs.completedExcersices.Palindromes;
using AlgoCastsCs.completedExcersices.reverseString;
using AlgoCastsCs.completedExcersices.ReversingInt;

namespace AlgoCastsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString.Test();
            ///////////////////////////////////////            
            Palindrome.Test();
            ///////////////////////////////////////           
            Palindrome.Test();
            ///////////////////////////////////////            
            ReverseInt.Test();
            ///////////////////////////////////////            
            FizzBuzz.Test();
            ///////////////////////////////////////     

            ArrayChunk.ArrayChunkProblem(new [] { 1, 2, 3, 4 }, 2);
        }

    }
}

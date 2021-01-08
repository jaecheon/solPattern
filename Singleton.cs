using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/25?category=672020
    public sealed class OptimizeSingleton
    {
        public string Name { get; set; }

        private static readonly OptimizeSingleton _instance = new OptimizeSingleton();

        public OptimizeSingleton()
        {

        }

        public static OptimizeSingleton Instance()
        {
            return _instance;
        }
    }
}

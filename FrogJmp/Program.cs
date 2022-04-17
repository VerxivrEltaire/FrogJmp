using System;

namespace FrogJmp {
    class Solution {
        public int solution(int X, int Y, int D) {

            double result = ((double)Y - (double)X) / (double)D;
            var count = result % 1 == 0 ? (int)result : result + 1;

            return (int)count;
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            var sol = new Solution();
            Console.WriteLine(sol.solution(10, 85, 30));
        }
    }
}

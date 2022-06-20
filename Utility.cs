using System;
namespace Task2 {
    public class Utility {

        public int value { get; set; }
        public long n { get; set; }

        public long Factorial() {
            long answer = 1;
            for(int idx = 1; idx <= value; idx++) {
                answer *= idx;
            }
            return answer;
        }

        public long Sum1ToN() {
            long sum = 0;
            for(int i = 1; i <= n; i++) {
                sum += i;
            }
            return sum;
        }
    }
}


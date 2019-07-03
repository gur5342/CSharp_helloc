using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworldc
{
    class Program
    {
        static void Main(string[] args)
        {
            // int sum = Enumerable.Range(1, 100).Where(x => x % 3 == 0).Sum(); 밑에 모든 줄을 포함하는 한 줄 표현

            // 합을 저장할 변수
            int sum = 0;

            // 1부터 100까지 반복
            for (int i = 1; i <= 100; i++)
            {
                // 만약 3의 배수라면, sum에 더한다
                if (i % 3 == 0)
                    sum = sum;
                //sum = sum + i;
                Console.WriteLine($"sum = {sum}, i = {i}"); // 디버깅용 로그 코드
            }

            // sum 출력
            Console.WriteLine(sum);
        }
    }
}


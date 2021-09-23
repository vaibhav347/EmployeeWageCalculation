using System;
namespace Flip
{
    class CoinFlip
    {
        int head = 0;
        int tail = 1;
        int headCount = 0;
        int tailCount = 0;
        void flipCoin()
        {
            Console.WriteLine("Enter How Many Times You Want To Toss : ");
            String toss = Console.ReadLine();
            int toss2 = Convert.ToInt32(toss);
            Console.WriteLine(toss2);
            for (int i = 1; i <= toss2; i++)
            {
                Random rand = new Random();
                int flip = rand.Next();
                flip = flip % 2;
                if (flip == head)
                {
                    headCount = headCount + 1;
                    
                }
                else
                {
                    tailCount = tailCount + 1;
                }
            }
            float headPercent = 0;
            headPercent = ((headCount * 100) / toss2 );
            float tailPercent = 0;
            tailPercent = ((tailCount* 100) / toss2 );
            Console.WriteLine("Head Count : "+headCount);
            Console.WriteLine("Tail Count : "+tailCount);
            Console.WriteLine("Head Percent : " + headPercent);
            Console.WriteLine("Tail Percent : " + tailPercent);

        }

           static void Main(string[] args)
            {
            CoinFlip obj = new CoinFlip();
            obj.flipCoin();
            }
        }

    }
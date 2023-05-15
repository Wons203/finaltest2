namespace finaltest2
{

    class program
    {
        static void Main(string[] args)
        {
            int[] Barray = new int[3];


            int b = 0;
            while (b == 0)
            {
                for (int i = 0; i < 3; ++i)
                {
                    Console.WriteLine("Please in put B{0}", i + 1);
                    int B = int.Parse(Console.ReadLine());
                    if (B > 0)
                    {
                        Barray[i] = B;
                    }


                }

                Console.WriteLine("Please in put B pay");
                int Bpay = int.Parse(Console.ReadLine());
                int a = 0;
                while (a == 0)
                {
                    int sum = 0;
                    while (sum >= 0)
                    {

                        sum = 0;
                        int sum2 = Barray[2] - Bpay;
                        Console.WriteLine("Balance3 :{0}", sum2);
                        if (sum2 <= 0)
                        {
                            sum = -1;
                        }

                        while (sum >= 0)
                        {

                            sum = 0;
                            int sum1 = Barray[1] - Bpay;
                            Console.WriteLine("Balannce2 :{0}", sum1);
                            if (sum1 <= 0)
                            {
                                sum = -1;
                            }

                            while (sum >= 0)
                            {

                                int sum3 = Barray[0] - Bpay;

                                if (sum3 <= 0)
                                {
                                    sum = -1;
                                }





                            }



                        }



                    }




                    Console.WriteLine("Left :{0}", Bpay);
                    b = 1;
                    break;

                }


            }

        }


        static int cal(int a, int b)
        {
            int sum = 0;
            sum = (a - b);
            return sum;



        }



    }





}


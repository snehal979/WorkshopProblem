namespace WorkShopProblem
{
    class Problem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the base value ");
            int BaseNum =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power value ");
            int PowerNum = Convert.ToInt32(Console.ReadLine());
            Problem p = new Problem(); 
            p.PowerOfNum(BaseNum ,PowerNum);
        }

        public  void PowerOfNum(int BaseNum ,int PowerNum)
        {
            
            int Result = 1;
            if(BaseNum >0 && PowerNum >0)
            {
                for (int i = 1; i <= PowerNum; i++)
                {
                    Result = Result * BaseNum;

                }
                Console.WriteLine("power of {2}^{0} is {1} ", PowerNum, Result,BaseNum);
            }
            else
            {
                Console.WriteLine("the number is negative");
            }
           

        }
    }
}
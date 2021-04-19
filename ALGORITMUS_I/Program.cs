using System;

namespace ALGORITMUS_I
{
    class MainClass
    {



        public static void KiirTomb(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("{0}, ", t[i]);
            }
            Console.WriteLine();
        }

        public static void ShellSort(int[] t)
        {
           
           
            int distance = t.Length / 2;

            while (distance > 0)
            {
                for (int i = 0; i < t.Length - distance; i++)
                {
                    int j = i + distance;
                    int tmp = t[j];
                    while (j >= distance && tmp < t[j - distance])
                    {
                        t[j] = t[j - distance];
                        j -= distance;
                    }
                    t[j] = tmp;
                }
                if (distance == 2) distance = 1;
                else distance = (int)(distance / 2.2);
            }
          
        }

 
        public static void CocktailShort(int[] t)
        {
            int start = 0; 
            int end = t.Length - 1; 
            bool hasChanged;
            int change = 0;

            do 
            {
                hasChanged = false; 
                for (int i = start; i <= end - 1; i++) 
                {
                    if (t[i] > t[i + 1]) 
                                        
                    {
                        change = t[i]; 
                        t[i] = t[i + 1]; 
                        t[i + 1] = change; 
                        hasChanged = true; 
                    }
                }
                end = end--; 
                if (hasChanged == true) 
                {
                    hasChanged = false; 
                    for (int i = end; i >= start + 1; i--) 
                    {
                        if (t[i] < t[i - 1]) 
                                             
                        {
                            change = t[i]; 
                            t[i] = t[i - 1]; 
                            t[i - 1] = change; 
                        }
                        hasChanged = true; 
                    }
                    start = start++; 
                }
            } while (hasChanged); 


        }

        


        public static void Main(string[] args)
        {
            int[] t = new int[] { 450, 130, 4, 11, 235, 631, 235, 111, 446, 893, 976 };

            CocktailShort(t);
            ShellSort(t);
            KiirTomb(t);
        }
    }
}

using System;
using System.Collections.Generic;

namespace DS_Project
{
    class SetOperations
    {
        public char[] Sub(int c ,char[] a,params char[] b)
        {
           
            var aa = new List<char>();
            aa.AddRange(a);
          
            foreach (var VAR1 in a)
            {
                foreach (var VAR2 in b)
                {
                    var cast = 0;
                    var cast2 =0;
                    cast = (int)VAR1;
                    cast2 = (int)VAR2;
                    if (cast==44)
                    {
                        break;
                    }
                    if (cast2 == 44)
                    {
                        continue;
                    }
                    if (VAR1==VAR2)
                    {
                        aa.Remove(VAR1);
                    }
                    
                }
            }

            var index = 0;
            while (index < aa.Count - 1)
            {
                if (aa[index] == aa[index + 1])
                    aa.RemoveAt(index);
                else
                    index++;
            }
            var charray = aa.ToArray();
            if (c == 1)
            {

                return charray;
            }

            foreach (var VARIABLE in aa)
            {
                if (VARIABLE==',')
                {
                    continue;
                }
               Console.Write(VARIABLE+",");
            }
            Console.WriteLine();
            return charray;
        }


        public char[] Union(int c,char[] a, params char[] b)
        {
            
            var aa = new List<char>();

            foreach (var VAR1 in a)
            {
                foreach (var VAR2 in b)
                {
                    var cast = 0;
                    var cast2 = 0;
                    cast = (int)VAR1;
                    cast2 = (int)VAR2;
                    if (cast == 44)
                    {
                        break;
                    }
                    if (cast2 == 44)
                    {
                        continue;
                    }
                    if (VAR1 == VAR2)
                    {
                        aa.Add(VAR1);
                    }
                    else
                    {
                        aa.Add(VAR1);
                        aa.Add(VAR2);
                    }

                }
            }

            for (var VARIABLE = 0; VARIABLE < aa.Count; VARIABLE++)
            {
                for (var VARIABLE1 = 0; VARIABLE1 < aa.Count; VARIABLE1++)
                {
                    if (aa[VARIABLE] < aa[VARIABLE1])
                    {
                        var temp = aa[VARIABLE1];
                        aa[VARIABLE1] = aa[VARIABLE];
                        aa[VARIABLE] = temp;
                    }
                }
            }
            var index = 0;
            while ( index < aa.Count - 1)
            {
                if (aa[index] == aa[index + 1])
                    aa.RemoveAt(index);
                else
                    index++;
            }
            var charray = aa.ToArray();
            if (c==1)
            {
                
                return charray;
            }

            foreach (var VARIABLE in aa)
            {
                Console.Write(VARIABLE + ",");
            }

            Console.WriteLine();
            return charray;

        }


        public void Intersection(char[] a, params char[] b)
        {
           
            var aa = new List<char>();
            foreach (var VAR1 in a)
            {
                foreach (var VAR2 in b)
                {
                    var cast = 0;
                    var cast2 = 0;
                    cast = (int)VAR1;
                    cast2 = (int)VAR2;
                    if (cast == 44)
                    {
                        break;
                    }
                    if (cast2 == 44)
                    {
                        continue;
                    }
                    if (VAR1 == VAR2)
                    {
                        aa.Add(VAR1);
                    }
                    

                }
            }


            var index = 0;
            while (index < aa.Count - 1)
            {
                if (aa[index] == aa[index + 1])
                    aa.RemoveAt(index);
                else
                    index++;
            }


            foreach (var VARIABLE in aa)
            {
                Console.Write(VARIABLE + ",");
            }
            Console.WriteLine();

        }
    }
}

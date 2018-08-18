using System;

namespace DS_Project
{
    static class Program
    {
        
        static char[] a, b,u;

        static readonly SetOperations Apply = new SetOperations();

        static void Main(string[] args)
        {

            Start();

            Console.Write("Answers:\n\n(A - B) =");
            AMinusB();

            Console.Write("(B - A) =");
            BMinusA();

            Console.Write("(A U B) =");
            AUnionB();

            Console.Write("(B U A) =");
            AUnionB();

            Console.Write("(A ∩ B) = ");
            AIntB();

            Console.Write("(B ∩ A) = ");
            AIntB();

            Console.Write("(A)'= ");
            AComp();

            Console.Write("(B)'= ");
            BComp();

            Console.Write("\n\nDeMorgan's Laws:" +
                              "\n(A U B)' == A' ∩ B'" +
                              "\n" +
                              "(A U B)' = ");
            AUnionBComp();
            Console.Write("\nA' ∩ B' = ");
            ACompIntBComp();
            Console.WriteLine("Hence Proved!\n");
        }

        static void Start()
        {
            Console.WriteLine("Furqan Ahmed 16B-117-SE");

            Console.WriteLine("//////DISCLAIMER: Set members should be single Character\\\\\\\n");


            Console.Write("Enter Elements of set U and press enter(Leave it blank," +
                              "if you want to)\nU= ");
            var setU = Console.ReadLine();
            Console.Write("Enter Elements of set A and press enter\nA= ");
            var setA = Console.ReadLine();
            Console.Write("Enter Elements of set B and press enter\nB= ");
            var setB = Console.ReadLine();


            u = setU.ToCharArray();
            a = setA.ToCharArray();
            b = setB.ToCharArray();

        }

        static void AMinusB()
        {
            Apply.Sub(0,a, b);
        }

        static void BMinusA()
        {
            Apply.Sub(0,b, a);
        }

        static void AUnionB()
        {
            Apply.Union(0,a,b);
        }

        static void AIntB()
        {
            Apply.Intersection(a,b);
        }

        static void AComp()
        {
            Apply.Sub(0,u,a);
        }

        static void BComp()
        {
            Apply.Sub(0,u, b);
        }

        static void AUnionBComp()
        {
            var charray = Apply.Union(1,a, b);
            Apply.Sub(0,u,charray);
        }

        static void ACompIntBComp()
        {
            var charray1=Apply.Sub(1,u,a);
            var charray2= Apply.Sub(1, u, b);
            Apply.Intersection(charray1,charray2);
        }

    }
}

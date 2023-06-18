namespace OopsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Duplicate_Element\n2.Unique_Elements\n3.Min_Max_Elements\n4.Star_Pattern\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Duplicat_Element.Duplicate();
                break;

                case 2:
                    Unique_Elements.Unique();
                    break;

                case 3:
                    Min_Max_Elements.Min_Max();
                    break;

                 case 4:
                    Star_Pattern.Star();
                    break;
            }


        }
    }
}
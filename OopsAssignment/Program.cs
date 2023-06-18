namespace OopsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Duplicate_Element\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Duplicat_Element.Duplicate();
                break;
            }


        }
    }
}
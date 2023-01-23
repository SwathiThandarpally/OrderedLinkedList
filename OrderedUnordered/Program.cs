namespace OrderedUnordered
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Display Ordered And Unorderd Linkedlist");
            //------Ordered Program--------------
            OrderedList orderList = new OrderedList();
            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            orderList.Ordered(word);

            //-------UnOrdered Program------------
            UnorderedList unorderedList = new UnorderedList();
            Console.WriteLine("Enter A Word ");
            string word1 = Console.ReadLine();
            unorderedList.UnOrdered(word);

            //-------Simple Paranthesis Program------------
            Console.WriteLine("Enter a word to search");
            SimpleParanthesis parenthesesProgram = new SimpleParanthesis();
            Console.WriteLine(parenthesesProgram.checkBalanced("Apple"));
            Console.WriteLine(parenthesesProgram.checkBalanced("(]"));
            Console.WriteLine(parenthesesProgram.checkBalanced("{"));
            Console.WriteLine(parenthesesProgram.checkBalanced("{}"));



        }
    }
}
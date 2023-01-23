namespace OrderedUnordered
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Display Ordered And Unorderd Linkedlist");

            OrderedList orderList = new OrderedList();

            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            orderList.Ordered(word);
        }
    }
}
namespace G_ASP_NET_101_C_Basics_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // This method tries to get the book price.
            // Expected result: found price is 25.5 for Clean Code.
            bool found = TryGetPrice("Clean Code", out double price);

            if (found)
            {
                Console.WriteLine($"Price: {price}");
            }

            #endregion
        }

        static bool TryGetPrice(string title, out double price)
        {
            // This checks if the title is Clean Code.
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }
    }
}

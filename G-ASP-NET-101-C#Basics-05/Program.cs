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

            #region Question 2

            // This method prints book title and pages.
            // Expected result: first call uses default pages 300.
            PrintBookInfo("C# Basics");

            // Expected result: second call uses pages 500.
            PrintBookInfo("ASP.NET Basics", 500);

            #endregion

            #region Question 3

            // This call uses named parameters.
            // Expected result: pages is sent before title.
            PrintBookInfo(pages: 450, title: "Named Parameters Book");

            #endregion

            #region Question 4

            // This method prints all titles.
            // Expected result: each title prints in a new line.
            PrintAllTitles("Clean Code", "C# Basics", "ASP.NET Core");

            #endregion

            #region Question 1

            Book book = new Book();

            // password is private, so we cannot print it here.
            // Expected result if we try: compile error because Main is outside Book class.
            // Console.WriteLine(book.password);

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

        static void PrintBookInfo(string title, int pages = 300)
        {
            // This prints book info.
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        static void PrintAllTitles(params string[] titles)
        {
            // This loop prints every title.
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }

    class Book
    {
        private string password = "secret";

        private void PrintPasswordInsideClass()
        {
            // Private can be used inside the same class only.
            Console.WriteLine(password);
        }
    }
}

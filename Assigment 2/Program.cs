namespace Assigment_2
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; } = "";
            public int Pages { get; set; }
        }
        static void Main(string[] args)
        {
            #region Q1:
            //   Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            object bookObj = new Book { Title = "Clean Code", Pages = 464 };
            Console.WriteLine(bookObj);
            #endregion

            #region Q2: 
            //  Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            Book book = new Book { Title = "Clean Code", Pages = 464 };
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion


            #region Q4:
            //  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            try
            {
                int zero = 0;
                int result = 10 / zero;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region Q5: 
            //  Declare an int pages = 300; then store it in a double variable without using a cast.
            int pages300 = 300;
            double pagesAsDouble = pages300;
            Console.WriteLine(pagesAsDouble);
            #endregion

            #region Q6:
            //  Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion

            #region Q7: 
            //  Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int pagesFromConvert = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesFromConvert);
            #endregion

            #region Q8: 
            //  Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            string yearText = "2023";
            int year2023 = int.Parse(yearText);
            Console.WriteLine(year2023);

            string badText = "abc";
            if (int.TryParse(badText, out int parsed))
                Console.WriteLine(parsed);
            else
                Console.WriteLine("Invalid number");
            #endregion

            #region Q9: 
            //   Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int pagesInt = 464;
            string pagesString = pagesInt.ToString();
            Console.WriteLine(pagesString.GetType());
            #endregion

            #region Q10:
            //   Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object boxed = copies;
            int unboxed = (int)boxed;
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
            #endregion

        }
    }
}

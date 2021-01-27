using System;
using System.Collections.Generic;

namespace Module_5_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser pages = new Browser();
            Stack<string> previousPage = new Stack<string>();
            Stack<string> forwardPage = new Stack<string>();

            //pages.AddToPreviousPages("old page 1");
            //pages.AddToPreviousPages("old page 2");
            //pages.AddToPreviousPages("old page 3");
            //pages.AddToPreviousPages("old page 4");

            pages.AddTForwardPages("new page 1");
            pages.AddTForwardPages("new page 2");
            pages.AddTForwardPages("new page 3");
            pages.AddTForwardPages("new page 4");

            Console.WriteLine("Previous Pages: ");
            pages.PrintPreviousPages();

            Console.WriteLine("New Pages: ");
            pages.PrintForwardPages();


            
            pages.forwardPages();
            Console.WriteLine("Changes: ");
            Console.WriteLine("Previous Pages: ");
            pages.PrintPreviousPages();

            Console.WriteLine("New Pages: ");
            pages.PrintForwardPages();

            pages.previousPages();
            Console.WriteLine("Undo Changes: ");
            Console.WriteLine("Previous Pages: ");
            pages.PrintPreviousPages();

            Console.WriteLine("New Pages: ");
            pages.PrintForwardPages();

        }
    }

    public class Browser
    {
        Stack<string> previousPage = new Stack<string>();
        Stack<string> forwardPage = new Stack<string>();

        public void AddToPreviousPages(string addOtPreviousPages)
        {
            previousPage.Push(addOtPreviousPages);
        }

        public void AddTForwardPages(string addOtForwardPages)
        {
            forwardPage.Push(addOtForwardPages);
        }


        public void previousPages()
        {
            string previousPages = previousPage.Pop(); forwardPage.Push(previousPages);
        }


        public void forwardPages()
        {
            string forwardPages = forwardPage.Pop(); previousPage.Push(forwardPages);
        }

        public void PrintPreviousPages()
        {
            foreach (var item in previousPage)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintForwardPages()
        {
            foreach (var item in forwardPage)
            {
                Console.WriteLine(item);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace Module_5_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser pages = new Browser();

            pages.newPageDirection("New Page");
            pages.oldPageDirection("Previous Page");

            pages.PrintnewPage();
            pages.PrintoldPage();
        }
    }

    public class Browser
    {
        private Stack<string> newPage = new Stack<string>();
        private Stack<string> oldPage = new Stack<string>();


        public void newPageDirection(string newDirection)
        {
            newPage.Push(newDirection);
        }

        public void oldPageDirection(string oldDirection)
        {
            oldPage.Push(oldDirection);
        }

        public void PrintnewPage()
        {
            foreach (var item in newPage)
            {
                Console.WriteLine("The page you are as viewing is: " + item);
            }
        }

        public void PrintoldPage()
        {
            foreach (var item in oldPage)
            {
                Console.WriteLine("The page you are as viewing is: " + item);
            }
        }

    }

}

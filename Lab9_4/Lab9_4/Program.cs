using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4
{
    class Header
    {
            StringBuilder htmlText = new StringBuilder();
            string headerOpen = "<header>";
            string headerClose = "</header>";

            String CreateHeader (string Text)
            {
            string header = string.Concat(headerOpen, Text, headerClose, "/n");
            return header;
            }

    }

    class UL
    {
        string ulOpen = "<ul>";
        string ulClose = "</ul>";

        string CreateULitem (string Text)
        {
            string liOpen = "<li>/n";
            string liClose = "</li>/n";

            string listitem = String.Concat(liOpen, Text, liClose, "/n");
            return listitem;
        }

    }

    StringBuilder CreateList(string[] listitems)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append();
        foreach (string item in listitems) ;
        {
            sb.Append(item);
        }
            sb.Append(close);
            return sb;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = "D://Users//jlloyd1//source//repos//Lab9_4//String.html";
            Header header = new Header();
            UL list = new UL();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter text for HTML header.");
            string headerElement = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add another item to the list.");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(headerElement);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());

        }
    }

}

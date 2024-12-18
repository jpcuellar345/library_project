using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    public class Book
    {
        private string author;
        private string title;
        private double publicPrecious;
        private double preciousBook;
        private int amount;

        public Book(string author, string title, double publicPrecious, double preciousBook, int amount)
        {
            this.author = author;
            this.title = title;
            this.publicPrecious = publicPrecious;
            this.preciousBook = preciousBook;
            this.amount = amount;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        public double PublicPrecious
        {
            get { return publicPrecious; }
            set
            {
                if (value >= 0)
                {
                    publicPrecious = value;
                }
                else
                {
                    throw new ArgumentException("El precio al publico del libro no puede ser negativo.");
                }
            }
        }

        public double PreciousBook
        {
            get { return preciousBook; }
            set
            {
                if (value >= 0)
                {
                    publicPrecious = value;
                }
                else
                {
                    throw new ArgumentException("El precio del libro comprado no puede ser negativo.");
                }
            }
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
                else
                {
                    throw new ArgumentException("La cantidad de ejemplares del libro no puede ser negativo.");
                }
            }
        }
    }
}

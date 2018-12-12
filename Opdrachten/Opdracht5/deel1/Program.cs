using System;

namespace Opdracht5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Author{
        private string name;
        private string email;
        private char gender;
    }
    public class Book{
            private string name;
            private Author author;
            private double price;
            private int qtyInStock;

            public Book(string name1, Author author1, double price1, int qtyInStock1){
                name = name1;
                author = author1;
                price = price1;
                qtyInStock = qtyInStock1;
            }

            public string getName(){
                return name;
            }

            public Author GetAuthor(){
                return author;
            }

            public double getPrice(){
                return price;
            }

            public void setPrice(double price1)
            {
                price = price1;
            }

            public int getQtyInStock(){
                return qtyInStock;
            }

            public void setQtyInStock(int qtyInStock1){
                qtyInStock = qtyInStock1;
            }

            public void print(){
                Console.WriteLine("Naam: " + name);
                Console.WriteLine("Auteur: " + author);
                Console.WriteLine("Prijs: " + price);
                Console.WriteLine("Aantal in stock: " + qtyInStock);
            }

            public string getAuthorname(){
                return author;
            }
        }
    
    
}

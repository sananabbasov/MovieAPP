using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeetDatabase.Seed();
            // Data Transformation Object
            //ContentCategory();
            //Product();
        }

        //private static void ContentCategory()
        //{
        //    ContentCategoryManager contentCategoryManager = new(new EfContentCategoryDal());

        //    foreach (var contentCategory in contentCategoryManager.GetContentDetails("Az"))
        //    {
        //        Console.WriteLine();
        //        foreach (var cat in contentCategory.Categories)
        //        {
        //            Console.WriteLine(cat.CategoryName);
        //        }
        //    }
        //}

        //private static void Product()
        //{
        //    ContentManager productManager = new(new EfContentDal());

        //    foreach (var product in productManager.GetAll())
        //    {
        //        Console.WriteLine("_____________________________________");
        //        Console.WriteLine("                                     ");
        //        Console.WriteLine("Name : " + product.Name + "\nIMDB : " + product.IMDB + "\nDescription : " + product.Description);
        //    }
        //    Console.WriteLine("_____________________________________");
        //}
    }
}

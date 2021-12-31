using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager u = new UserManager(new EfUserDal());
            foreach (var item in u.GetAll().Data)
            {
                
                Console.WriteLine();
            }
        }
    }
}

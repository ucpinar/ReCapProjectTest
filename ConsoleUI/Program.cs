﻿using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramwork;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrace);
            }
        }
    }
}

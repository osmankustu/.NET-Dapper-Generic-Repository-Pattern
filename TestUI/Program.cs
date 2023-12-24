﻿

using Autofac.Extensions.DependencyInjection;
using Entites.Concrete;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TestUI.Concrete;

ProductRepository productRepository = new ProductRepository();
Stopwatch Stopwatch = new Stopwatch();
Random random = new Random();
string islem = "0";
int milliseconds = 2000;

Console.WriteLine("GetAll İşlemi Başlıyor");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i} işlem Başlıyor..");
    for (int j = 0; j < 10; j++)
    {
        getAll();
    }
    Thread.Sleep(milliseconds);
}
Console.WriteLine("Get By Id İşlemi Başlıyor");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}. işlem ");
    for (int j = 0; j < 10; j++)
    {
        int x = random.Next(1, 590);
        getById(x);
    }
    Thread.Sleep(milliseconds);

}




//add(newProduct);
//update(newProduct);
//delete(newProduct);
void getById(int id)
{
    Stopwatch.Start();
    productRepository.Get(id);
    Stopwatch.Stop();
    Console.WriteLine($"Perormance : {Stopwatch.Elapsed.TotalSeconds}");
    Stopwatch.Reset();
}

void update(Products p)
{
    productRepository.update(p);
    Console.WriteLine("Updated");
    getAll();
}


void delete(Products p)
{
    productRepository.delete(p);
    Console.WriteLine("Deleted");
    getAll();
}



void getAll()
{
    Stopwatch.Start();
    List<Products> list = productRepository.getAll();
    Stopwatch.Stop();
    Console.WriteLine($"Perormance : {Stopwatch.Elapsed.TotalSeconds}");
    Stopwatch.Reset();
}

void add(Products p)
{
    productRepository.add(p);
    Console.WriteLine("Added");
    getAll();
}

Console.ReadKey();
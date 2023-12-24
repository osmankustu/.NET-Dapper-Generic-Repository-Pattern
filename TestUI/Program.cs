

using Entites.Concrete;
using System.Collections.Generic;
using TestUI.Concrete;

ProductRepository productRepository = new ProductRepository();

Products newProduct = new Products()
{
    Id = 2,
    name = "Apple AirPods",
    price = 11700,
    quantity = 10
};
getAll();

//add(newProduct);
//update(newProduct);
//delete(newProduct);

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
    List<Products> list =productRepository.getAll();
    foreach (var item in list)
    {
        Console.WriteLine($"ID : {item.Id} NAME : {item.name} STOK ADEDİ : {item.quantity} FİYAT : {item.price}" );
    }
}

void add(Products p)
{
    productRepository.add(p);
    Console.WriteLine("Added");
    getAll();
}
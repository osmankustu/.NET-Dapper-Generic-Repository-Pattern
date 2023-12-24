using Entites.Concrete;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using TestUI.Concrete;

ProductRepository productRepository = new ProductRepository();
Stopwatch stopwatch = new Stopwatch();
Random random = new Random();

string islem = "0";
int milliseconds = 2000;

Console.WriteLine("GetAll İşlemi Başlıyor");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}. işlem ");
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
        int x = random.Next(1,590);
        getById(x);
    }
    Thread.Sleep(milliseconds);

}





//add(newProduct);
//update(newProduct);
//delete(newProduct);
void getById(int id)
{
    stopwatch.Start();
    productRepository.Get(id,p=>p.Id == id);
    stopwatch.Stop();
    Console.WriteLine($"Perormance : {stopwatch.Elapsed.TotalSeconds}");
    stopwatch.Reset();
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
    stopwatch.Start();
    List<Products> list = productRepository.getAll();
    stopwatch.Stop();
    Console.WriteLine($"Perormance : {stopwatch.Elapsed.TotalSeconds}");
    stopwatch.Reset();
}

void add(Products p)
{
    productRepository.add(p);
    Console.WriteLine("Added");
    getAll();
}


Console.ReadKey();
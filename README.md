
# .NET Dapper and Ef Generic Repository 

Hello friends, in this project you can see how the generic repository is created. If you want, you can use it in your projects, just star it :). Thanks


## Appendix

I did some tests. According to my results, Dapper is much more fluid and faster than EF, and the average response time of Dapper is 0.0007626 ms, while EF's is 0.0023998 ms.


## Documentation

copy the repository and run it in Visual Studio.
The database consists of 1 table, the table name is products >>contains >> you just need to create id,name,quantity,price

## SQL Command
CREATE TABLE Products(
    id INT PRIMARY KEY IDENTITIY(1,1),
    name nvarchar(100) NOT NULL,
    quantity int NOT NULL,
    price Decimal NOT NULL
)


## Tech Stack

**Client:** Console App

**Server:** .NET


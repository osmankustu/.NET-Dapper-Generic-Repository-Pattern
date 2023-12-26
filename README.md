
# .NET Dapper and Ef Generic Repository 

Hello friends, in this project you can see how the generic warehouse is created. If you want, you can use it in your projects, just star it :). Thanks


## Appendix

I did some tests. According to my results, Dapper is much more fluid and faster than EF, and the average response time of Dapper is 0.0078029 ms, while EF's is 0.0944477 ms.


## Documentation

Copy the repository and run Web API Project it in Visual Studio.


## API Reference

#### Get all items

```http
  GET /api/Product
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `null` | `null` | **Required**. Your API key |

#### Get item

```http
  GET /api/Product/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of item to fetch |




## Screenshots
- Dapper 
![Dapper](https://i.hizliresim.com/3rg72r4.png)
- Entity Framework
![Entity Framnework](https://i.hizliresim.com/arsyyov.png)

## Tech Stack

**Client:** ASP.NET CORE WEB API

**Server:** ISS EXPRESS


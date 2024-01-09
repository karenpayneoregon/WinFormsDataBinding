# About

NET8 mirrow image of MoveBetweenListBoxes (which was done in Framework 4.7) using Dapper. By using Dapper, data operations saved 30 lines of code.


![Screen](assets/screen.png)

```csharp
internal class DataOperations
{
    private IDbConnection _cn = new SqlConnection(ConnectionString());

    public async Task<List<Customer>> CustomersList()
    {
        var statement =
            """
            SELECT Identifier,
                   CompanyName,
                   ContactName,
                   ContactTypeIdentifier,
                   GenderIdentifier
            FROM dbo.Customer
            ORDER BY CompanyName;
            """;

        return (await _cn.QueryAsync<Customer>(statement)).AsList();
    }

    public async Task<List<Gender>> GenderList() 
        => (await _cn.QueryAsync<Gender>("SELECT id, GenderType FROM Genders")).AsList();
}
```
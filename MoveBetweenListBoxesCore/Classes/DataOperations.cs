using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using MoveBetweenListBoxesCore.Models;

using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace MoveBetweenListBoxesCore.Classes;
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

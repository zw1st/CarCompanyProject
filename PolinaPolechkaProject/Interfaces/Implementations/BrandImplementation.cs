using Dapper;
using Npgsql;
using PolinaPolechkaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Interfaces.Implementations;

public class BrandImplementation : IOperations<Brand>
{
    private readonly IConnectionString _connectionString;

    public BrandImplementation(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }

    public void Create(Brand variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
                INSERT INTO Brands (BrandName, Country)
                VALUES (@BrandName, @Country)";
            connection.Execute(queryInsert, variable);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Delete(int id)
    {
        
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var count = connection.QuerySingle<int>(
            "SELECT COUNT(*) FROM Cars WHERE BrandId = @BrandId", new { BrandId = id });
            if (count != 0)
            {
                throw new InvalidOperationException($"Удаление элемента с ID {id} невозможно, так как он используется в таблице Cars.");
            }
            var queryDelete = @"
                DELETE FROM Brands
                WHERE Id=@id";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<Brand> ReadAll(string? brandName = null, string? country = null)
    {
        try
        {
            var builder = new QueryBuilder();
            var parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(brandName))
            {
                builder.AddCondition("BrandName ILIKE @brandName");
                parameters.Add("@brandName", $"%{brandName}%");
            }
            if (!string.IsNullOrEmpty(country))
            {
                builder.AddCondition("Country ILIKE @country");
                parameters.Add("@country", $"%{country}%");
            }

            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = $"SELECT * FROM Brands {builder.Build()}";
            var brands = connection.Query<Brand>(querySelect, parameters);
            return brands;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<Brand> ReadAll()
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Brands";
            var brands = connection.Query<Brand>(querySelect);
            return brands;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Brand ReadById(int id)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT * FROM Brands
                WHERE Id=@id";
            var brand = connection.QueryFirst<Brand>(querySelect, new { id });
            return brand;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(Brand variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                UPDATE Brands
                SET
                BrandName=@BrandName,
                Country=@Country
                WHERE Id=@Id";
            connection.Execute(queryUpdate, variable);
        }
        catch (Exception)
        {
            throw;
        }
    }
}

using Dapper;
using Npgsql;
using PolinaPolechkaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Interfaces.Implementations;

public class FactoryImplementation : IOperations<Factory>
{
    private readonly IConnectionString _connectionString;

    public FactoryImplementation(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }


    public void Create(Factory variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
                INSERT INTO Factories (Name, Adress, FoundationDate)
                VALUES (@Name, @Adress, @FoundationDate)";
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
            connection.Open();

            // Проверяем, есть ли записи в таблице Cars, использующие данный FactoryId
            var count = connection.QuerySingle<int>(
                "SELECT COUNT(*) FROM Cars WHERE FactoryId = @FactoryId", new { FactoryId = id });

            if (count != 0)
            {
                throw new InvalidOperationException($"Удаление элемента с ID {id} невозможно, так как он используется в таблице Cars.");
            }

            // Удаляем запись из таблицы Factory
            var queryDelete = "DELETE FROM Factories WHERE Id = @Id";
            connection.Execute(queryDelete, new { Id = id });
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
            throw;
        }
    }

    public IEnumerable<Factory> ReadAll(string? Name = null, string? Adress = null, DateTime? dateFrom = null, DateTime? dateTo = null)
    {
        try
        {
            var builder = new QueryBuilder();
            var parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(Name))
            {
                builder.AddCondition("Name ILIKE @factoryName");
                parameters.Add("@factoryName", $"%{Name}%");
            }
            if (!string.IsNullOrEmpty(Adress))
            {
                builder.AddCondition("Adress ILIKE @adress");
                parameters.Add("@adress", $"%{Adress}%");
            }
            if (dateFrom.HasValue)
            {
                builder.AddCondition("FoundationDate >= @dateFrom");
                parameters.Add("@dateFrom", dateFrom.Value);
            }
            if (dateTo.HasValue)
            {
                builder.AddCondition("FoundationDate <= @dateTo");
                parameters.Add("@dateTo", dateTo.Value);
            }


            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = $"SELECT * FROM Factories {builder.Build()}";
            var factories = connection.Query<Factory>(querySelect, parameters);
            return factories;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<Factory> ReadAll()
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Factories";
            var factories = connection.Query<Factory>(querySelect);
            return factories;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Factory ReadById(int id)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT * FROM Factories
                WHERE Id=@id";
            var factory = connection.QueryFirst<Factory>(querySelect, new { id });
            return factory;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(Factory variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
    UPDATE Factories
    SET
        Name = @Name,
        Adress = @Adress,
        FoundationDate = @FoundationDate
    WHERE Id = @Id";
            connection.Execute(queryUpdate, variable);
        }
        catch (Exception)
        {
            throw;
        }
    }
}

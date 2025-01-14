using Dapper;
using Npgsql;
using PolinaPolechkaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Interfaces.Implementations;

public class CarShopImplementation : IOperations<CarShop>
{
    private readonly IConnectionString _connectionString;

    public CarShopImplementation(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }

    public void Create(CarShop variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
                INSERT INTO CarShop (ShopName, Rating, Guarantee)
                VALUES (@ShopName, @Rating, @Guarantee)";
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

            // Проверяем, есть ли записи в таблице Cars, использующие данный CarShopId
            var count = connection.QuerySingle<int>(
                "SELECT COUNT(*) FROM Cars WHERE CarShopId = @CarShopId", new { CarShopId = id });

            if (count != 0)
            {
                throw new InvalidOperationException($"Удаление элемента с ID {id} невозможно, так как он используется в таблице Cars.");
            }

            // Удаляем запись из таблицы CarShop
            var queryDelete = "DELETE FROM CarShop WHERE Id = @Id";
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

    public IEnumerable<CarShop> ReadAll(string? shopName = null, int? ratingFrom = null, int? ratingTo = null, int? guaranteeFrom = null, int? guaranteeTo = null)
    {
        try
        {
            var builder = new QueryBuilder();
            var parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(shopName))
            {
                builder.AddCondition("ShopName ILIKE @shopName");
                parameters.Add("@shopName", $"%{shopName}%");
            }

            if (ratingFrom.HasValue)
            {
                builder.AddCondition("Rating >= @ratingFrom");
                parameters.Add("@ratingFrom", ratingFrom.Value);
            }

            if (ratingTo.HasValue)
            {
                builder.AddCondition("Rating <= @ratingTo");
                parameters.Add("@ratingTo", ratingTo.Value);
            }

            if (guaranteeFrom.HasValue)
            {
                builder.AddCondition("Guarantee >= @guaranteeFrom");
                parameters.Add("@guaranteeFrom", guaranteeFrom.Value);
            }

            if (guaranteeTo.HasValue)
            {
                builder.AddCondition("Guarantee <= @guaranteeTo");
                parameters.Add("@guaranteeTo", guaranteeTo.Value);
            }

            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = $"SELECT * FROM CarShop {builder.Build()}";
            var carShops = connection.Query<CarShop>(querySelect, parameters);
            return carShops;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<CarShop> ReadAll()
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM CarShop";
            var carShops = connection.Query<CarShop>(querySelect);
            return carShops;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public CarShop ReadById(int id)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT * FROM CarShop
                WHERE Id = @id";
            var carShop = connection.QueryFirst<CarShop>(querySelect, new { id });
            return carShop;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(CarShop variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                UPDATE CarShop
                SET
                    ShopName = @ShopName,
                    Rating = @Rating,
                    Guarantee = @Guarantee
                WHERE Id = @Id";
            connection.Execute(queryUpdate, variable);
        }
        catch (Exception)
        {
            throw;
        }
    }
}


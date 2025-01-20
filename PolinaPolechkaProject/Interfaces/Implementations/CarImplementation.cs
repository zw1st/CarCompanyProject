using Dapper;
using Npgsql;
using PolinaPolechkaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PolinaPolechkaProject.Interfaces.Implementations;

public class CarImplementation : IOperations<Car>
{
    private readonly IConnectionString _connectionString;

    public CarImplementation(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }

    public void Create(Car variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
                INSERT INTO Cars (FactoryId, CarShopId, BrandId, OwnerId, ReleaseYear, Price, DriveType, IsAutomatic)
                VALUES (@FactoryId, @CarShopId, @BrandId, @OwnerId, @ReleaseYear, @Price, @DriveType, @IsAutomatic)";
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
            var queryDelete = @"
                DELETE FROM Cars
                WHERE Id=@id";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<Car> ReadAll(string? factory = null, string? carShop = null, string? brand = null, string? owner = null,
                                 DateTime? releaseYearMin = null, DateTime? releaseYearMax = null,
                                 int? priceMin = null, int? priceMax = null,
                                 Entities.DriveType? driveType = null, bool? isAutomatic = null)
    {

        if (releaseYearMin.HasValue && releaseYearMax.HasValue && releaseYearMin > releaseYearMax)
        {
            throw new ArgumentException("Минимальный год выпуска не может быть больше максимального года выпуска.");
        }

        if (priceMin.HasValue && priceMax.HasValue && priceMin > priceMax)
        {
            throw new ArgumentException("Минимальная цена не может быть больше максимальной цены.");
        }
        try
        {
            var builder = new QueryBuilder();
            var parameters = new DynamicParameters();
            //
            if (!string.IsNullOrEmpty(factory))
            {
                builder.AddCondition("Name ILIKE @Factory");
                parameters.Add("@Factory", $"%{factory}%");
            }
            if (!string.IsNullOrEmpty(brand))
            {
                builder.AddCondition("BrandName ILIKE @Brand");
                parameters.Add("@Brand", $"%{brand}%");
            }
            if (!string.IsNullOrEmpty(carShop))
            {
                builder.AddCondition("ShopName ILIKE @CarShop");
                parameters.Add("@CarShop", $"%{carShop}%");
            }
            if (!string.IsNullOrEmpty(owner))
            {
                builder.AddCondition("FullName ILIKE @Owner");
                parameters.Add("@Owner", $"%{owner}%");
            }
            //
            if (releaseYearMin.HasValue)
            {
                builder.AddCondition("ReleaseYear >= @releaseYearMin");
                parameters.Add("@releaseYearMin", releaseYearMin.Value);
            }
            if (releaseYearMax.HasValue)
            {
                builder.AddCondition("ReleaseYear <= @releaseYearMax");
                parameters.Add("@releaseYearMax", releaseYearMax.Value);
            }
            if (priceMin.HasValue)
            {
                builder.AddCondition("Price >= @priceMin");
                parameters.Add("@priceMin", priceMin.Value);
            }
            if (priceMax.HasValue)
            {
                builder.AddCondition("Price <= @priceMax");
                parameters.Add("@priceMax", priceMax.Value);
            }
            if (driveType != Entities.DriveType.None)
            {
                builder.AddCondition("DriveType = @driveType");
                parameters.Add("@driveType", driveType);
            }
            if (isAutomatic.HasValue)
            {
                builder.AddCondition("IsAutomatic = @isAutomatic");
                parameters.Add("@isAutomatic", isAutomatic.Value);
            }

            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @$"SELECT 
    crs.*, 
    fctr.Name as Factory,
    shp.ShopName as CarShop, 
    ownr.FullName as Owner, 
    brnd.BrandName as Brand
FROM Cars crs
LEFT JOIN Factories fctr ON fctr.Id = crs.FactoryId
LEFT JOIN CarShop shp ON shp.Id = crs.CarShopId
LEFT JOIN Owners ownr ON ownr.Id = crs.OwnerId
LEFT JOIN Brands brnd ON brnd.Id = crs.BrandId
{builder.Build()}";
            var cars = connection.Query<Car>(querySelect, parameters);
            return cars;
        }
        catch (Exception)
        {
            throw;
        }
    }


    public IEnumerable<Car> ReadAll()
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Cars";
            var owners = connection.Query<Car>(querySelect);
            return owners;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Car ReadById(int id)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT * FROM Cars
                WHERE Id=@id";
            var car = connection.QueryFirst<Car>(querySelect, new { id });
            return car;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(Car variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                UPDATE Cars
                SET
                FactoryId=@FactoryId,
                CarShopId=@CarShopId,
                BrandId=@BrandId,
                OwnerId=@OwnerId,
                ReleaseYear=@ReleaseYear,
                Price=@Price,
                DriveType=@DriveType,
                IsAutomatic=@IsAutomatic
                WHERE Id=@Id";
            connection.Execute(queryUpdate, variable);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
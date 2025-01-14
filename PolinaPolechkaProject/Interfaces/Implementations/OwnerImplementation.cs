using Dapper;
using Npgsql;
using PolinaPolechkaProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PolinaPolechkaProject.Interfaces.Implementations;

public class OwnerImplementation : IOperations<Owner>
{
    private readonly IConnectionString _connectionString;

    public OwnerImplementation(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }


    public void Create(Owner variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
                INSERT INTO Owners (FullName, Phone, Email, Adress)
                VALUES (@FullName, @Phone, @Email, @Adress)";
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

            // Проверяем, есть ли записи в таблице Cars, использующие данный OwnerId
            var count = connection.QuerySingle<int>(
                "SELECT COUNT(*) FROM Cars WHERE OwnerId = @OwnerId", new { OwnerId = id });

            if (count != 0)
            {
                throw new InvalidOperationException($"Удаление элемента с ID {id} невозможно, так как он используется в таблице Cars.");
            }

            // Удаляем запись из таблицы Owner
            var queryDelete = "DELETE FROM Owners WHERE Id = @Id";
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

    public IEnumerable<Owner> ReadAll(string? fullName = null, string? phone = null, string? email = null, string? adress = null)
    {
        try
        {
            var builder = new QueryBuilder();
            var parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(fullName))
            {
                builder.AddCondition("FullName ILIKE @fullName");
                parameters.Add("@fullName", $"%{fullName}%"); 
            }
            if (!string.IsNullOrEmpty(phone))
            {
                builder.AddCondition("Phone ILIKE @phone");
                parameters.Add("@phone", $"%{phone}%"); 
            }
            if (!string.IsNullOrEmpty(email))
            {
                builder.AddCondition("Email ILIKE @email");
                parameters.Add("@email", $"%{email}%"); 
            }
            if (!string.IsNullOrEmpty(adress))
            {
                builder.AddCondition("Adress ILIKE @adress");
                parameters.Add("@adress", $"%{adress}%"); 
            }


            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = $"SELECT * FROM Owners {builder.Build()}";
            var owners = connection.Query<Owner>(querySelect, parameters);
            return owners;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<Owner> ReadAll()
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Owners";
            var owners = connection.Query<Owner>(querySelect);
            return owners;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Owner ReadById(int id)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT * FROM Owners
                WHERE Id=@id";
            var expense = connection.QueryFirst<Owner>(querySelect, new { id });
            return expense;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(Owner variable)
    {
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                UPDATE Owners
                SET
                FullName=@FullName,
                Phone=@Phone,
                Email=@Email,
                Adress=@Adress
                WHERE Id=@Id";
            connection.Execute(queryUpdate, variable);
        }
        catch (Exception)
        {
            throw;
        }
    }
}

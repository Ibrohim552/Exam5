using Dapper;
using Infrustructure.Mapping;
using Npgsql;
namespace Infrustructure.Service;
using Infrustructure.SqlCommand;

public class ServicecQuery
{
    public static IEnumerable<Query1> Query1()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query1>(SqlCommand.select1);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public static IEnumerable<Query2> Query2()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query2>(SqlCommand.select2);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }public static IEnumerable<Query3> Query3()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query3>(SqlCommand.select3);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public static IEnumerable<Query4> Query4()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query4>(SqlCommand.select4);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    
    public static IEnumerable<Query5> Query5()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query5>(SqlCommand.select5);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    } 
    public static IEnumerable<Query6> Query6()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query6>(SqlCommand.select6);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    } 
    public static IEnumerable<Query9> Query9()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query9>(SqlCommand.select9);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public static IEnumerable<Query10> Query10()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query10>(SqlCommand.select10);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public static IEnumerable<Query11> Query11()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connection))
            {
                connection.Open();
                return connection.Query<Query11>(SqlCommand.select11);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    
}
}
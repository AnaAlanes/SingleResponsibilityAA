using Npgsql;
using System;
using System.Collections.Generic;

namespace CalculadoraDemo.Utils
{
    public static class OperationMultiplication
    {
        public static IEnumerable<object[]> GetMultiplicationData()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=Control123$%;Database=operations";
            List<object[]> tableData = new List<object[]>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"MultiplicationData\"";

                var npgsqlCommand = new NpgsqlCommand(query, connection);

                // Here the command is Executed
                var dataReader = npgsqlCommand.ExecuteReader();

                // Here is read the columns 
                var fieldCount = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCount];

                    int instances = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }

                return tableData;
            }
        }
    }
}

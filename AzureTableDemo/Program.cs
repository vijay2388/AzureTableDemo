using Microsoft.Azure.Cosmos.Table;
using System;

namespace AzureTableDemo
{
    class Program
    {
        private static string connection_string = "DefaultEndpointsProtocol=https;AccountName=vjdemostorage2021;AccountKey=8imyu30fFw7rqHaYz8oOkWQK/y40e0w/dIR6IuiOPZm9qSDlaZnZpaTHc8w56x/rx/nIVdG4uyd6AxhvE3n3iA==;EndpointSuffix=core.windows.net";
        private static string table_name = "Customer";

        static void Main(string[] args)
        {
            CloudStorageAccount _account = CloudStorageAccount.Parse(connection_string);

            CloudTableClient _client = _account.CreateCloudTableClient();

            //Creating Table 
            CloudTable _table = _client.GetTableReference(table_name);
            _table.CreateIfNotExists();

            Console.WriteLine("Table created successfully");

            //Insert Record in the table
            Customer _customer = new Customer("UserA", "Chicago", "C1");

            TableOperation _operation = TableOperation.Insert(_customer);

            TableResult _result = _table.Execute(_operation);

            Console.WriteLine("Customer is added");

            Console.ReadKey();
        }
    }
}

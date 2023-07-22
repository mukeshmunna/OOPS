
using OOps.StockAccountManagement;
using OOPs.DataInventoryManagement;
using System.Collections.Generic;
using System.Security.AccessControl;

internal class Program

{
    static string invertory_filePath = @"D:\Problem statemets\OOPs\OOPs\OOPs\StockAccountManagement\CompanyStock.json";
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Stock Account Management -->");
        StockOperation details = new StockOperation();
        details.ReadStockJson(invertory_filePath);


    }
}




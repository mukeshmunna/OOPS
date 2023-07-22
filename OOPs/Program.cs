
using OOps.CommercialDataProcessing;
using OOps.StockAccountManagement;
using OOPs.DataInventoryManagement;
using System.Collections.Generic;
using System.Security.AccessControl;

internal class Program

{

    static string invertory_filePath_Company = @"D:\Problem statemets\OOPs\OOPs\OOPs\StockAccountManagement\CompanyStock.json";

    static string invertory_filePath_Customer = @"D:\Problem statemets\OOPs\OOPs\OOPs\CommercialDataProcessing\CustomerStock.json";
    private static void Main(string[] args)
    {

        Console.WriteLine("CommercialData Processsing :");

        Console.WriteLine("\n");
        Console.WriteLine("Enter The amount");
        int amount = Convert.ToInt32(Console.ReadLine());
        StockOperation details = new StockOperation();
        CustomerStockOperation customer = new CustomerStockOperation();

        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter input :\n1.stocks List \n2.Buy Stocks \n3.Sell stocks \n4.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Company Stock Details");
                    details.ReadStockJson(invertory_filePath_Company);
                    Console.WriteLine("\nCustomer Stock Details");
                    customer.ReadCustomerStock(invertory_filePath_Customer);
                    customer.CustomerStockoperation(amount);

                    break;
                case 2:
                    Console.WriteLine("\n Buy Stock");
                    customer.CustomerBuyStockFromCompany();
                    customer.WriteToCompanyFile(invertory_filePath_Company);
                    customer.WriteToCustumerFile(invertory_filePath_Customer);
                    break;

                case 3:
                    Console.WriteLine("Selling stock");
                    customer.CustomerSellStockFromCompany();
                    customer.WriteToCompanyFile(invertory_filePath_Company);
                    customer.WriteToCustumerFile(invertory_filePath_Customer);
                    break;
                case 4:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }



            }
        }
    }




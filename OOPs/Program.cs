
using OOPs.DataInventoryManagement;
using System;


namespace OOPs
{
    public class program
    {
        static string inventory_filePath = @"D:\Problem statemets\OOPs\OOPs\OOPs\DataInventoryManagement\InventoryData.json";
        public static void Main(string[] args)
        {
            InventoryDetailsOperation details = new InventoryDetailsOperation();
            details.ReadInventoryJson(inventory_filePath);
        }
    }
}


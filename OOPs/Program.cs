using OOPs.DataInventoryManagement;
using OOPs.InventoryManagement;
using System;

namespace OOPs
{
    class Program
    {
        
        static string filePath = @"D:\Problem statemets\OOPs\OOPs\OOPs\InventoryManagement\InventoryManagementData.json";
        public static void Main(String[] args)
        {

            { 
 
                        bool flag = true;
                        InventoryManagementOperation inventoryManagementOperation = new InventoryManagementOperation();
                        while (flag)
                        {
                            Console.WriteLine("1.read files\n2.add values\n3.delete Value\n4.update to json");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    inventoryManagementOperation.ReadInventoryJson(filePath);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the crop name ");
                                    string cropName = Console.ReadLine();
                                    inventoryManagementOperation.AddInventoryManagement(cropName);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the crop name ");
                                    cropName = Console.ReadLine();
                                    Console.WriteLine("Enter the crop name ");
                                    string inventoryName = Console.ReadLine();
                                    inventoryManagementOperation.DeleteValue(cropName, inventoryName);
                                    break;
                                case 4:
                                    inventoryManagementOperation.AddToJsonFile(filePath);
                                    break;
                                default:
                                    flag = false;
                                    break;

                            }
                        }

                }
            }
        }
    }

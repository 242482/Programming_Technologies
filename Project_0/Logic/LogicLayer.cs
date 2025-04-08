using Project_0.Data;
using System;
using System.Collections.Generic;

namespace Project_0.Logic
{
    public class LogicLayer
    {
        private readonly DataLayer _dataLayer;

        // Constructor takes an instance of DataLayer
        public LogicLayer(DataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        // Add an item to the data store through the data layer
        public void AddItemToStore(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                Console.WriteLine("Item cannot be null or empty.");
                return;
            }

            _dataLayer.AddItem(item);
            Console.WriteLine($"Item '{item}' added successfully.");
        }

        // Get all items from the data store
        public List<string> GetItems()
        {
            return _dataLayer.GetAllItems();
        }

        // Check if an item exists in the data store
        public bool DoesItemExist(string item)
        {
            return _dataLayer.ItemExists(item);
        }
    }
}
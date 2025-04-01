using System;
using System.Collections.Generic;

namespace Project_0.Data
{
    public class DataLayer
    {
        private List<string> _dataStore;

        public DataLayer()
        {
            _dataStore = new List<string>();  // Initialize with an empty list
        }

        // Add data item to the store
        public void AddItem(string item)
        {
            _dataStore.Add(item);
        }

        // Get all data items from the store
        public List<string> GetAllItems()
        {
            return _dataStore;
        }

        // Find item by name (just for illustration)
        public bool ItemExists(string item)
        {
            return _dataStore.Contains(item);
        }
    }
}
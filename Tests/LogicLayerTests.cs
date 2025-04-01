using Project_0.Logic;
using Project_0.Data;
using System;
using NUnit.Framework;

namespace Project_0.Tests
{
    [TestFixture]
    public class LogicLayerTests
    {
        private readonly LogicLayer _logicLayer;

        public LogicLayerTests()
        {
            // Initialize LogicLayer with a mock DataLayer
            var dataLayer = new DataLayer();
            _logicLayer = new LogicLayer(dataLayer);
        }

        [Test]
        public void AddItemToStore_ShouldAddItemSuccessfully()
        {
            
            string itemName = "Item1";

            
            _logicLayer.AddItemToStore(itemName);

            
            var items = _logicLayer.GetItems();
            Assert.IsTrue(items.Contains(itemName));
        }

        [Test] 
        public void DoesItemExist_ShouldReturnTrueIfItemExists()
        {
            
            string itemName = "Item2";
            _logicLayer.AddItemToStore(itemName);

            
            bool result = _logicLayer.DoesItemExist(itemName);

            
            Assert.IsTrue(result); // Verifies that the item exists
        }

        [Test]  
        public void DoesItemExist_ShouldReturnFalseIfItemDoesNotExist()
        {
            
            string itemName = "NonExistentItem";

            
            bool result = _logicLayer.DoesItemExist(itemName);

            
            Assert.IsFalse(result); // Verifies that the item does not exist
        }

        [Test]  
        public void GetItems_ShouldReturnAllAddedItems()
        {
            
            _logicLayer.AddItemToStore("Item1");
            _logicLayer.AddItemToStore("Item2");

            
            var items = _logicLayer.GetItems();

            
            Assert.IsTrue(items.Contains("Item1"));
            Assert.IsTrue(items.Contains("Item2"));
        }
    }
}

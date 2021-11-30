using System;
using BookStore;
using NUnit.Framework;

namespace BookStoreTests
{
    public class HarryPotterBookStoreTests
    {
        private HarryPotterBookStore _bookStore;

        [SetUp]
        public void Setup()
        {
            _bookStore = new HarryPotterBookStore();
        }

        [Test]
        public void Buy_First_One_Book()
        {
            _bookStore = new HarryPotterBookStore();
            var price = _bookStore.GetPrice(new short[] { 1, 0, 0, 0 });
            Assert.AreEqual(300, price);
        }

        [Test]
        public void Buy_First_And_Second_One_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 1, 1, 0, 0 });
            Assert.AreEqual(540, price);
        }

        [Test]
        public void Buy_First_To_Third_One_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 1, 1, 1, 0 });
            Assert.AreEqual(720, price);
        }

        [Test]
        public void Buy_First_To_Four_One_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 1, 1, 1, 1 });
            Assert.AreEqual(840, price);
        }        
        
        [Test]
        public void Buy_First_And_Four_One_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 1, 0, 0, 1 });
            Assert.AreEqual(540, price);
        }

        [Test]
        public void Buy_First_Tow_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 2, 0, 0, 0 });
            Assert.AreEqual(600, price);
        }        
        
        [Test]
        public void Buy_First_And_Second_Tow_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 2, 2, 0, 0 });
            Assert.AreEqual(1080, price);
        }        
        
        [Test]
        public void Buy_First_One_Book_And_Second_To_Four_One_Book()
        {
            var price = _bookStore.GetPrice(new short[] { 2, 1, 1, 1 });
            Assert.AreEqual(1140, price);
        }
    }
}
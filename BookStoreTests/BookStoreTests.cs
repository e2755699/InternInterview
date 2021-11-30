using NUnit.Framework;

namespace BookStoreTests
{
    public class BookStoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Open()
        {
            var bookStore = new BookStore.BookStore();
            var message = bookStore.Open();
            Assert.AreEqual("Book Store is open now", message);
        }
        [Test]
        public void Buy_One_Book()
        {
            var bookStore = new BookStore.BookStore();
            var price = bookStore.GetPrice(1);
            Assert.AreEqual(300, price);
        }
        [Test]
        public void Buy_Two_Book()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(2);
	        Assert.AreEqual(600, price);
        }

        [Test]
        public void Buy_Three_Book()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(3);
	        Assert.AreEqual(720, price);
        }

        [Test]
        public void Buy_Four_Book()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(4);
	        Assert.AreEqual(960, price);
        }

        [Test]
        public void Buy_Five_Book()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(5);
	        Assert.AreEqual(1050, price);
        }

        [Test]
        public void Buy_Seven_Book()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(7);
	        Assert.AreEqual(1260, price);
        }

        [Test]
        public void Buy_One_Book_With_One_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(1,1);
	        Assert.AreEqual(200, price);
        }

        [Test]
        public void Buy_Two_Book_With_One_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(2, 1);
	        Assert.AreEqual(500, price);
        }

        [Test]
        public void Buy_Three_Book_With_Three_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(3, 3);
	        Assert.AreEqual(600, price);
	        //600, 720
        }

        [Test]
        public void Buy_Three_Book_With_One_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(3, 1);
	        Assert.AreEqual(720, price);
            //800, 720
        }

        [Test]
        public void Buy_Five_Book_With_Five_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(5, 5);
	        Assert.AreEqual(1000, price);
            //1000, 1050
        }

        [Test]
        public void Buy_Five_Book_With_One_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(5, 1);
	        Assert.AreEqual(1050, price);
            //1400, 1050
        }

        [Test]
        public void Buy_Seven_Book_With_Seven_Coupon()
        {
	        var bookStore = new BookStore.BookStore();
	        var price = bookStore.GetPrice(7, 7);
	        Assert.AreEqual(1260, price);
            //1400, 1260
        }
    }
}
using System;

namespace BookStore
{
    public class BookStore
    {
        public string Open()
        {
            return "Book Store is open now";
        }

        public int GetPrice(int bookAmount)
        {
	        throw new NotImplementedException();
            //$300 per book
            //Multi-Book-Package
            //20% discount off for each book when buying over 3 books in one transaction
            //30% discount off for each book when buying over 5 books in one transaction
            //40% discount off for each book when buying 7 books in one transaction
        }

        public int GetPrice(int bookAmount, int coupon)
        {
	        throw new NotImplementedException();
            //1 coupon could deduct $100 for 1 book
            //each book could only be applied with 1 coupon
            //coupon could NOT be used with Multi-Book-Package in a same transaction, which means if any coupon is used, the Multi-Book-Package should be ignored
            //if the price with coupon is higher than the price with Multi-Book-Package, the lower one would be the final price
        }
    }
}

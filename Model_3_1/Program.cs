using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Model_3_1
{
    public enum CourierCompany
    {
        DHL,
        AmazonPrime,
        ExpressPony
    }
    public enum DeliveryType
    {
        OneDay,
        Usual
    }

    public static class Extensions
    {
        public static bool IsExpress(this DeliveryType deliveryType)
        {
            return DeliveryType.OneDay == deliveryType;
        }
    }

    abstract class Delivery 
    {
        public static int TotalDelivery = 0;
        public Basket<Article> Basket { get; private set; }
        public CourierCompany Company { get; private set; }
        public DeliveryType DeliveryType { get; private set; }
        public string Address { get; private set; }

        protected Delivery( Basket<Article> basket, string address, CourierCompany company, DeliveryType deliveryType)
        {
            Basket = basket;
            Address = address;
            Company = company;
            DeliveryType = deliveryType;
            ++TotalDelivery;
        }

       

        public abstract void ShowInfoDelivery();

    }
    class HomeDelivery : Delivery
    {
        public DateTime DeliveryTime;

        public HomeDelivery(DateTime deliveryTime, Basket<Article> basket, string address, CourierCompany company, DeliveryType deliveryType) : base(basket, address, company, deliveryType)
        {
            DeliveryTime = deliveryTime;
            
        }

        public override void ShowInfoDelivery()
        {
            Console.WriteLine( $"Home Delivery to {Address} at {DeliveryTime}.\n " +
                $"Busket:{Basket.GetArticles()}\n" +
                $"Delivery company:{Company}\n" +
                $"Delivery type: {DeliveryType} " +
                $"Price:{Basket.GetTotalPrice()}" );
        }
    }
    class ShopDelivery : Delivery
    {
        public DateTime PickUpTime;

        public ShopDelivery(DateTime pickUpTime, Basket<Article> basket, string address, CourierCompany company, DeliveryType deliveryType) : base(basket, address, company, deliveryType)
        {
            PickUpTime = pickUpTime;
        }
        public override void ShowInfoDelivery()
        {
            Console.WriteLine($"Shop Delivery to {Address} at {PickUpTime}.\n " +
                $"Busket:{Basket.GetArticles()}\n" +
                $"Delivery company:{Company}\n" +
                $"Delivery type: {DeliveryType} " +
                $"Price:{Basket.GetTotalPrice()}");
        }
    }
    class PickPointDelivery : Delivery
    {
        public DateTime PickUpTime;

        public PickPointDelivery(DateTime pickUpTime, Basket<Article> basket, string address, CourierCompany company, DeliveryType deliveryType) : base(basket, address, company, deliveryType)
        {
            PickUpTime = pickUpTime;
        }
        public override void ShowInfoDelivery()
        {
            Console.WriteLine($"Shop Delivery to {Address} at {PickUpTime}.\n " +
                $"Busket:{Basket.GetArticles()}\n" +
                $"Delivery company:{Company}\n" +
                $"Delivery type: {DeliveryType}" +
                $"Price:{Basket.GetTotalPrice()}");
        }
    }
    class Article 
    {
        public string Title { get; private set; }
        public int Id { get; private set; }
        public decimal Price { get; private set; }

        public Article(string Title, int Id, decimal Price) 
        {
            this.Title = Title;
            this.Id = Id;
            this.Price = Price;
        }
    }
    class OfflineArticle : Article
    {
        private string ShopAddress { get; set; }
        public OfflineArticle(string Title, int Id, decimal Price, string shopAddress) : base(Title, Id, Price)
        {
            ShopAddress = shopAddress;
        }
    }
    class Basket<TArticle>
    {
        private static int _basketCounter = 0;
        public int Id { get; private set; }

        private List<TArticle> _articles = new();

        public void AddArticle(TArticle article)
        {
            _articles.Add(article);
        }

        public string GetArticles()
        {
            return string.Join(", ", _articles.Select(a => a.Title));
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;

            foreach (TArticle article in _articles)
            {
                total += article.Price;
            }
            return total;

        }

        public Basket()
        {
            Id = ++_basketCounter;
        }

        public TArticle this[int index]
        {
            get { return _articles[index]; }
            set { _articles[index] = value; }
        }

    }

    class OfflineBasket<TOfflineArticle> : Basket<TOfflineArticle> where TOfflineArticle : OfflineArticle
    {
        
    }




    class Program
    {
        static void Main()
        {
          
        }
    }
}


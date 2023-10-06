using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_CHIRUNGA.Models
{
    internal class DeskQuote
    {
        private const decimal PRICE_PER_INCH = 1;
        private const decimal COST_PER_DRAWER = 50;
        internal Desk Desk;
        internal string CustomerName;
        private DateTime now;

        internal DateTime Date {  get; set; }
        private decimal BaseDeskPrice {  get; set; }
        private decimal AdditionalSquareInchCost { get; set;}
        private decimal DrawerCost { get; set; }
        private decimal SurfaceMaterialCost { get; set; }
        private decimal RushOrderCost { get; set; }
        public decimal TotalPrice { get; set; }

        
        public DeskQuote (string customerName, int width, int depth, int numberOfDrawers, 
                DesktopMaterial desktopMaterial, int rushOrderDays)
        {
            Date = DateTime.Today;
            this.CustomerName = customerName;
            Desk = new Desk(width, depth, numberOfDrawers, desktopMaterial, rushOrderDays);
            BaseDeskPrice = 200;
        }

        public DeskQuote(Desk desk, string customerName, DateTime now)
        {
            Desk = desk;
            CustomerName = customerName;
            this.now = now;
        }

        public void CreateNewQuote()
        {
            AdditionalSquareInchCost = CalculateAdditionalSquareInchCost();
            DrawerCost = CalculateDrawerCost();
            SurfaceMaterialCost = CalculateSurfaceMaterialCost();
            RushOrderCost = CalculateRushOrderCost();
            TotalPrice = CalculateTotalPrice();
        }

        public decimal CalculateAdditionalSquareInchCost()
        {
            decimal squareInches = Desk.Width * Desk.Depth;
            decimal squareInchCost = squareInches * PRICE_PER_INCH;
            return squareInchCost;
        }

        public decimal CalculateDrawerCost()
        {
            return COST_PER_DRAWER * Desk.NumberOfDrawers;
        }

        public decimal CalculateSurfaceMaterialCost()
        {
            return (decimal)Desk.DesktopMaterial;
        }

        public decimal CalculateRushOrderCost() 
        { 
            decimal squareInches = Desk.Width * Desk.Depth;
            int rush = Desk.RushOrderDays;

            if(rush == 14) 
            {
                return 0;
            }
            //priceChart Coordinates
            int[] rushOrderHeader = { 3, 5, 7 };
            int[] deskSizeHeader = { 1000, 2000, 4610 };

            //squareInchIndex
            int indexSize = Array.FindIndex(deskSizeHeader, header => squareInches < header);
            //Index matching rush days
            int indexRush = Array.IndexOf(rushOrderHeader, rush);

            //priceChart
            decimal[,] priceChart = new decimal[,]
            {
                {60, 70, 80 },
                {40, 50, 60 },
                {30, 35, 40 }
            };
            return priceChart[indexSize, indexRush];
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice;
            totalPrice = BaseDeskPrice + AdditionalSquareInchCost + DrawerCost + SurfaceMaterialCost + RushOrderCost;
            return totalPrice;
        }
    }
}

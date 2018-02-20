using System;
using DumbStock.RR.forms.Models;
namespace DumbStock.RR.Models
{
    public class Strategy : IFirebaseItem
    {
        public string Id
        {
            get;
            set;
        }
        public string Ticker
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }
        public double RiskPct
        {
            get;
            set;
        }
        public double RewardPct
        {
            get;
            set;
        }
        public int NumShares
        {
            get;
            set;
        }
        public DateTime SoldAt
        {
            get;
            set;
        }
        public string TickerDesc
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        }
        public DateTime CreatedAt
        {
            get;
            set;
        }
        public DateTime UpdatedAt
        {
            get;
            set;
        }
        public bool Deleted
        {
            get;
            set;
        }
    }
}

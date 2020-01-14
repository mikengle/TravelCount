using System;

namespace TravelCount.Contracts.Persistence
{
    public interface IExpense : IIdentifiable, ICopyable<IExpense>
    {
        public int TravelId { get; set; }
        public DateTime Date { get;}
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Friend { get; set; }

    }
}

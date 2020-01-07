using System;

namespace TravelCount.Contracts.Persistence
{
    public interface IExpense : IIdentifiyable, ICopyable<IExpense>
    {
        public int TravelId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Friend { get; set; }

    }
}

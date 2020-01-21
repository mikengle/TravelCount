namespace TravelCount.Transfer
{
    public abstract class TransferObject : Contracts.IIdentifiable
    {
        public int Id { get; set; }
    }
}

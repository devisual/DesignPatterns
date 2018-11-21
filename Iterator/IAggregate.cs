namespace Iterator
{
    internal interface IAggregate
    {
        IIterator Iterator();
        string this[int index] { get;set; }
        int Count { get; }
    }
}
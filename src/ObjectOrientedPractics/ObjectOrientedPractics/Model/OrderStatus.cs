namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Order status
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
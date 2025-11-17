namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents the current status of an order in the system.
    /// Defines the lifecycle stages from creation to final disposition.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// The order has been created but not yet processed.
        /// Initial state after customer submission.
        /// </summary>
        New,

        /// <summary>
        /// The order is being reviewed and validated by the system or operator.
        /// Payment verification, inventory check, etc.
        /// </summary>
        Processing,

        /// <summary>
        /// The order is being prepared for shipment.
        /// Items are picked and packed in the warehouse.
        /// </summary>
        Assembly,

        /// <summary>
        /// The order has been dispatched and is in transit.
        /// Shipped via courier or postal service.
        /// </summary>
        Sent,

        /// <summary>
        /// The order has been successfully delivered to the customer.
        /// Final successful state.
        /// </summary>
        Delivered,

        /// <summary>
        /// The order was returned by the customer.
        /// May lead to refund or replacement.
        /// </summary>
        Returned,

        /// <summary>
        /// The order was abandoned due to timeout, cancellation, or payment failure.
        /// Considered closed without fulfillment.
        /// </summary>
        Abandoned
    }
}
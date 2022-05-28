namespace CloudChampion.Warehouse.ViewModels
{
	public enum OrderStatus
	{
		Created,
		ProcessingAvailabilityInStock,
		ProcessingOrderConfirmation,
		ProcessingPlanShipping,
		ProcessingNotification,
		Completed
	}
}

using System;

namespace CloudChampion.Warehouse.ViewModels
{
	public record OrderEvent(Guid OrderId, OrderStatus OrderStatus);
}

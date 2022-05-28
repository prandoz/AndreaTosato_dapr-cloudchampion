using System.Threading.Tasks;
using CloudChampion.Warehouse.ViewModels;
using Dapr;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CloudChampion.Warehouse.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WarehouseController : ControllerBase
	{
		private readonly ILogger<WarehouseController> _logger;

		public WarehouseController(ILogger<WarehouseController> logger)
		{
			_logger = logger;
		}

		[Topic("pubsub", "orderprocessed")]
		[HttpPost("orderprocessed")]
		public async Task OrderProcessed(OrderEvent @event)
		{
			_logger.LogDebug($"Warhouse order processed {@event.OrderId}");
		}
	}
}

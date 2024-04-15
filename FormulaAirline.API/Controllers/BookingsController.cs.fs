using Microsoft.AspNetCore.Mvc;

using FormulaAirline.API.Controller.

namespace FormulaAirline.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingsController : ControllerBase
{
    private readonly ILogger<BookingsController> _logger;
    private readonly IMessageProducer _messageProducer;

    //IN MEMORY DB
    public static readonly List<Booking> _bookings = new();

    public BookingsController(
        ILogger<BookingsController> logger,
        IMessageProducer messageProducer
    )
    {
        _logger = logger;
        _messageProducer = messageProducer;
    }
}

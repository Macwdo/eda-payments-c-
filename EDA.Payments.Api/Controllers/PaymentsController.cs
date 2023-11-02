using EDA.Payments.Api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EDA.Payments.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentsController
{
    public PaymentsController()
    {

    }

    [HttpPost]
    public PaymentResponse Create(PaymentRequest request)
    {
        return new PaymentResponse(
            Guid.NewGuid(),
            request.Username,
            request.PixKey,
            request.Amount,
            DateTime.Now
        );
    }
}
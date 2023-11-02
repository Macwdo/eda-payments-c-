using System.ComponentModel.DataAnnotations;
using WebApplication1.Validators;

namespace EDA.Payments.Api.DTOs;

public record PaymentResponse(
    Guid TransactionId,
    [Required] string Username,
    [Required] [PixKeyTypeValidator] EPixKeyType PixKey,
    decimal Amount,
    DateTime CreatedAt
);
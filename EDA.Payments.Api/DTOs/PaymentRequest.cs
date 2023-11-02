using System.ComponentModel.DataAnnotations;
using WebApplication1.Validators;

namespace EDA.Payments.Api.DTOs;

public record PaymentRequest(
    [Required] string Username,
    [Required] [PixKeyTypeValidator] EPixKeyType PixKeyType,
    [Required] string PixKey,
    decimal Amount
);
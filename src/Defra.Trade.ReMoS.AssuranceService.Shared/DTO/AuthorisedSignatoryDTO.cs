namespace Defra.Trade.ReMoS.AssuranceService.Shared.DTO;

public class AuthorisedSignatoryDto
{
    public Guid Id { get; set; }        
    public string? Name { get; set; }
    public string? EmailAddress { get; set; }
    public string? Position { get; set; }
    public DateTime SubmittedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public Guid ModifiedBy { get; set; }
}

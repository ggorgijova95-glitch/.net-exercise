namespace Lamazon.Domain.Entites;

public class Invoice : BaseEntity
{
    public string InvoiceNumber { get; set; } = string.Empty;
    public DateTime InvoiceDate { get; set; }
    public decimal TotalAmount { get; set; }
    //Relations
    public int UserId { get; set; }
    public required User User { get; set; }

    public int OrderId { get; set; }
    public required Order Order { get; set; }

    public int InvoiceStatusId { get; set; }
    public required InvoiceStatus InvoiceStatus { get; set; }

    public ICollection<InvoiceLineItem> InvoiceLineItems { get; set; } = [];
}

namespace Lamazon.Domain.Entites;



public class InvoiceLineItem : BaseEntity
{
    public string ProductName { get; set; } = string.Empty;
    public decimal ProductPrice { get; set; }
    public int Quantity { get; set; }
    public int DiscountPercentage { get; set; }
    public decimal TotalPrice { get; set; }

    //Relations
    public int InvoiceId { get; set; }
    public required Invoice Invoice { get; set; }
    public int OrderLineItemId { get; set; }
    public required OrderLineItem OrderLineItem { get; set; }
    public int ProductId { get; set; }

    public required Product Product { get; set; }


}

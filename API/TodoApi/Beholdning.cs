using Microsoft.EntityFrameworkCore;


[Keyless]
public class Beholdning{

    public int? ShopID { get; set; }
    public string? ean { get; set; }
    public int? InventoryQuantity { get; set; }
    public int? supplierID { get; set; }
}
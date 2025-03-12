


using System.ComponentModel.DataAnnotations;

public class ProductData {
    [Key]
    public int IDENT {get; set;}
    public string Kampagnenavn {get; set;}
	public string? Valutakode {get; set;}
	public string KAEDE {get; set;}
	public DateTime? FRADATO {get; set;}
	public DateTime? TILDATO {get; set;}

}
namespace StoreApp.Web.Models
{
    public class ProductViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;

    }

    public class ProductListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; } = Enumerable.Empty<ProductViewModel>();
        public SayfaBilgisi SayfaBilgisi { get; set; } = new();
    }
    public class SayfaBilgisi
    {
      public int CurrentPage { get; set; }
        public int ToplamOge { get; set; }
        public int SayfaBasinaDusenOge { get; set; }
        public int ToplamSayfa => (int)Math.Ceiling((decimal)ToplamOge/SayfaBasinaDusenOge); 
    }


}

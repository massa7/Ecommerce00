

namespace Core.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string ProdPicture { get; set; }
        
       // [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        public bool IsOnSale { get; set; }  
        public bool IsOnStock { get; set; }
        public string ProdSize { get; set; }
        public string ProdGender { get; set; }
        public string ProdFormat { get; set; }  
        public string ProdDescription { get; set; }

        
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

         public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }



       // public string ProdMake { get; set; }
      //  public DateTime ProdCreated { get; set; }
       // public DateTime ProdUpdated { get; set; }
    }
}
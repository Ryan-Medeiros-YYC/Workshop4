﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelExpertsData.Models;

[Index("ProductId", Name = "ProductId")]
public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [StringLength(50)]
    public string ProdName { get; set; } = null!;

    [InverseProperty("Product")]
    public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; } = new List<ProductsSupplier>();
}

public class ProductDTO
{
    public int ProductId { get; set; }
    public string ProdName { get; set; } = null!;
    
}
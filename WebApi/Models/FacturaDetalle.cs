﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class FacturaDetalle
{
    public int IdFacturaDetalle { get; set; }

    public int IdFactura { get; set; }

    public int IdProducto { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; }

    public virtual Producto IdProductoNavigation { get; set; }
}
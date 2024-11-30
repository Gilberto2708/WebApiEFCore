﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public int? Stock { get; set; }

    public decimal? Costo { get; set; }

    public int? Estado { get; set; }

    public DateOnly? Fecha { get; set; }

    public string UnidadSat { get; set; }

    public string ClaveSat { get; set; }

    public int IdCategoria { get; set; }

    public int IdLinea { get; set; }

    public int? EsProducto { get; set; }

    public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; } = new List<FacturaDetalle>();

    public virtual Categorium IdCategoriaNavigation { get; set; }

    public virtual Linea IdLineaNavigation { get; set; }
}
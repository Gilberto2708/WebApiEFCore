﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class FormaPago
{
    public int IdFormaPago { get; set; }

    public string FormaDePago { get; set; }

    public string Codigo { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
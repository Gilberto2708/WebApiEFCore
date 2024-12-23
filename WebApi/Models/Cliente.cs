﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; }

    public string Apellidos { get; set; }

    public string Direccion { get; set; }

    public string Cp { get; set; }

    public string RegimenFiscal { get; set; }

    public string Telefono { get; set; }

    public string Rfc { get; set; }

    public DateOnly? FechaAlta { get; set; }

    public bool? Activo { get; set; }

    public string Ciudad { get; set; }

    public string Municipio { get; set; }

    public string Localidad { get; set; }

    public string Pais { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__8A3D240C733E7519", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cp = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    RegimenFiscal = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RFC = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    FechaAlta = table.Column<DateOnly>(type: "date", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    Ciudad = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    Municipio = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    Localidad = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    Pais = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cliente__885457EE2155E23A", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "EstadoDocumento",
                columns: table => new
                {
                    IdEstadoDocumento = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EstadoDo__4989F2B7C43D736F", x => x.IdEstadoDocumento);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormaDePago = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FormaPag__C777CA683503716D", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Linea",
                columns: table => new
                {
                    idLinea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Linea__4F210ABF8A578DAA", x => x.idLinea);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPago",
                columns: table => new
                {
                    IdMetodoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MetodoPa__6F49A9BE7192DD0A", x => x.IdMetodoPago);
                });

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Moneda__AA690671DECBEDF4", x => x.IdMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    UnidadSAT = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    ClaveSAT = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdLinea = table.Column<int>(type: "int", nullable: false),
                    EsProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__09889210038FC54E", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "idCategoria");
                    table.ForeignKey(
                        name: "FK_Producto_Linea",
                        column: x => x.IdLinea,
                        principalTable: "Linea",
                        principalColumn: "idLinea");
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serie = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    Folio = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    IdEstadoDocumento = table.Column<int>(type: "int", nullable: true),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    TotalImpuestos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdFormaPago = table.Column<int>(type: "int", nullable: false),
                    IdMetodoPago = table.Column<int>(type: "int", nullable: false),
                    IdMoneda = table.Column<int>(type: "int", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Factura__50E7BAF1A8781B02", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_Factura_EstadoDocumento",
                        column: x => x.IdEstadoDocumento,
                        principalTable: "EstadoDocumento",
                        principalColumn: "IdEstadoDocumento");
                    table.ForeignKey(
                        name: "FK_Factura_FormaPago",
                        column: x => x.IdFormaPago,
                        principalTable: "FormaPago",
                        principalColumn: "IdFormaPago");
                    table.ForeignKey(
                        name: "FK_Factura_MetodoPago",
                        column: x => x.IdMetodoPago,
                        principalTable: "MetodoPago",
                        principalColumn: "IdMetodoPago");
                    table.ForeignKey(
                        name: "FK_Factura_Moneda",
                        column: x => x.IdMoneda,
                        principalTable: "Moneda",
                        principalColumn: "IdMoneda");
                });

            migrationBuilder.CreateTable(
                name: "FacturaDetalle",
                columns: table => new
                {
                    IdFacturaDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFactura = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    IVA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Importe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FacturaD__3D8E1AB8805FFD78", x => x.IdFacturaDetalle);
                    table.ForeignKey(
                        name: "FK_FacturaDetalle_Factura",
                        column: x => x.IdFactura,
                        principalTable: "Factura",
                        principalColumn: "IdFactura");
                    table.ForeignKey(
                        name: "FK_FacturaDetalle_Producto",
                        column: x => x.IdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Cliente",
                table: "Factura",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_EstadoDocumento",
                table: "Factura",
                column: "IdEstadoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FormaPago",
                table: "Factura",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_MetodoPago",
                table: "Factura",
                column: "IdMetodoPago");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Moneda",
                table: "Factura",
                column: "IdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetalle_Factura",
                table: "FacturaDetalle",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetalle_Producto",
                table: "FacturaDetalle",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Categoria",
                table: "Producto",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Linea",
                table: "Producto",
                column: "IdLinea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturaDetalle");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "EstadoDocumento");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "MetodoPago");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Linea");
        }
    }
}

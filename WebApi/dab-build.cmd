@echo off
@echo This cmd file creates a Data API Builder configuration based on the chosen database objects.
@echo To run the cmd, create an .env file with the following contents:
@echo dab-connection-string=your connection string
@echo ** Make sure to exclude the .env file from source control **
@echo **
dotnet tool install -g Microsoft.DataApiBuilder
dab init -c dab-config.json --database-type mssql --connection-string "@env('dab-connection-string')" --host-mode Development
@echo Adding tables
dab add "Categorium" --source "[dbo].[Categoria]" --fields.include "idCategoria,Descripcion" --permissions "anonymous:*" 
dab add "Cliente" --source "[dbo].[Cliente]" --fields.include "idCliente,Nombre,Apellidos,Direccion,Cp,RegimenFiscal,Telefono,RFC,FechaAlta,Activo,Ciudad,Municipio,Localidad,Pais" --permissions "anonymous:*" 
dab add "EstadoDocumento" --source "[dbo].[EstadoDocumento]" --fields.include "IdEstadoDocumento,Estado" --permissions "anonymous:*" 
dab add "Factura" --source "[dbo].[Factura]" --fields.include "IdFactura,Serie,Folio,IdEstadoDocumento,Subtotal,TotalDescuento,IdCliente,TotalImpuestos,Total,IdFormaPago,IdMetodoPago,IdMoneda,FechaEmision" --permissions "anonymous:*" 
dab add "FacturaDetalle" --source "[dbo].[FacturaDetalle]" --fields.include "IdFacturaDetalle,IdFactura,IdProducto,IVA,Descuento,Importe,Cantidad,PrecioUnitario" --permissions "anonymous:*" 
dab add "FormaPago" --source "[dbo].[FormaPago]" --fields.include "IdFormaPago,FormaDePago,Codigo" --permissions "anonymous:*" 
dab add "Linea" --source "[dbo].[Linea]" --fields.include "idLinea,Descripcion" --permissions "anonymous:*" 
dab add "MetodoPago" --source "[dbo].[MetodoPago]" --fields.include "IdMetodoPago,Descripcion,Codigo" --permissions "anonymous:*" 
dab add "Monedum" --source "[dbo].[Moneda]" --fields.include "IdMoneda,Nombre,Codigo" --permissions "anonymous:*" 
dab add "Producto" --source "[dbo].[Producto]" --fields.include "IdProducto,Codigo,Descripcion,PrecioUnitario,Stock,Costo,Estado,Fecha,UnidadSAT,ClaveSAT,IdCategoria,IdLinea,EsProducto" --permissions "anonymous:*" 
@echo Adding views and tables without primary key
@echo Adding relationships
dab update Factura --relationship Cliente --target.entity Cliente --cardinality one
dab update Cliente --relationship Factura --target.entity Factura --cardinality many
dab update Factura --relationship EstadoDocumento --target.entity EstadoDocumento --cardinality one
dab update EstadoDocumento --relationship Factura --target.entity Factura --cardinality many
dab update Factura --relationship FormaPago --target.entity FormaPago --cardinality one
dab update FormaPago --relationship Factura --target.entity Factura --cardinality many
dab update Factura --relationship MetodoPago --target.entity MetodoPago --cardinality one
dab update MetodoPago --relationship Factura --target.entity Factura --cardinality many
dab update Factura --relationship Monedum --target.entity Monedum --cardinality one
dab update Monedum --relationship Factura --target.entity Factura --cardinality many
dab update FacturaDetalle --relationship Factura --target.entity Factura --cardinality one
dab update Factura --relationship FacturaDetalle --target.entity FacturaDetalle --cardinality many
dab update FacturaDetalle --relationship Producto --target.entity Producto --cardinality one
dab update Producto --relationship FacturaDetalle --target.entity FacturaDetalle --cardinality many
dab update Producto --relationship Categorium --target.entity Categorium --cardinality one
dab update Categorium --relationship Producto --target.entity Producto --cardinality many
dab update Producto --relationship Linea --target.entity Linea --cardinality one
dab update Linea --relationship Producto --target.entity Producto --cardinality many
@echo Adding stored procedures
@echo **
@echo ** run 'dab validate' to validate your configuration **
@echo ** run 'dab start' to start the development API host **

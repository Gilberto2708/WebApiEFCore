# Creamos un array con todos los modelos (excluyendo DbContext)

#dotnet add package Microsoft.EntityFrameworkCore.Tools
#dotnet add package Microsoft.EntityFrameworkCore.SqlServer
#dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
#dotnet aspnet-codegenerator controller -name CategoriumController -async -api -m Categorium -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name ClienteController -async -api -m Cliente -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name EstadoDocumentoController -async -api -m EstadoDocumento -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name FacturaController -async -api -m Factura -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name FacturaDetalleController -async -api -m FacturaDetalle -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name FormaPagoController -async -api -m FormaPago -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name LineaController -async -api -m Linea -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name MetodoPagoController -async -api -m MetodoPago -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name MonedumController -async -api -m Monedum -dc Db_FacturaContext -outDir Controllers

#dotnet aspnet-codegenerator controller -name ProductoController -async -api -m Producto -dc Db_FacturaContext -outDir Controllers
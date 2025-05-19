StockFlowERP
Bu proje, temel bir stok ve ürün yönetimi için .NET 7 Web API örneğidir.

Kullanılan Teknolojiler
ASP.NET Core 7 Web API
Entity Framework Core 7
SQL Server (EMRE\SQLEXPRESS01 örneği ile)
Swagger (API dokümantasyonu ve test için)
Kurulum ve Çalıştırma
NuGet Paketlerini Yükle

Gerekli paketler:
Microsoft.AspNetCore.OpenApi
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Swashbuckle.AspNetCore
Terminalden yüklemek için:
dotnet add package Microsoft.AspNetCore.OpenApi --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
Temel API'ler
GET /api/products : Ürünleri listeler
POST /api/products : Yeni ürün ekler
POST /api/auth/login : Kullanıcı girişi (demo: admin/admin)
Notlar
Şifreler ve JWT demo amaçlıdır, gerçek projede güvenlik eklenmelidir.
Kodlar sade ve örnek amaçlıdır.

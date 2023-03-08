# ImageGalleryApp
### A demo app in Clean Architecture

dotnet ef commands for managing database..
```
dotnet ef migrations add <name> -c AppDbContext -p src/ImageGalleryApp.Infrastructure -s src/ImageGalleryApp.Api -o Data/Migrations
dotnet ef migrations remove -c AppDbContext -p src/ImageGalleryApp.Infrastructure -s src/ImageGalleryApp.Api
dotnet ef database update -c AppDbContext -p src/ImageGalleryApp.Infrastructure -s src/ImageGalleryApp.Api
```

# ImageGalleryApp
### A demonstration app in Clean Architecture

Make sure to update connection string in appsettings.json.

Update database using the dotnet cli command..
```
dotnet ef database update -c AppDbContext -p src/ImageGalleryApp.Infrastructure -s src/ImageGalleryApp.Api
```

Run ImageGalleyApp.Api project via Visual Studio or follow dotnet cli command..
```
dotnet run --project src/ImageGalleryApp.Api/ImageGalleryApp.Api.csproj
```

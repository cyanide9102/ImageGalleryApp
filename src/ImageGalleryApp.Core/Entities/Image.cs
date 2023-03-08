using ImageGalleryApp.Core.Interfaces;

namespace ImageGalleryApp.Core.Entities;
public class Image : EntityBase, IAggregateRoot
{
    public Image(string name, string path)
    {
        Name = name;
        Path = path;
    }

    public string Name { get; set; }
    public string Path { get; set; }
}

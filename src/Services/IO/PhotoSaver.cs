using System;
using System.IO;
using LacmusApp.Models.Photo;

namespace LacmusApp.Services.IO
{
    public class PhotoSaver : IPhotoSaver
    {
        public void Save(Photo photo, string source)
        {
            using (var stream = File.Create(source))
            {
                try
                {
                    photo.ImageBrush.Source.Save(stream);
                }
                catch (Exception e)
                {
                    throw new Exception($"unable save image to {source}", e);
                }
            }
        }
    }
}
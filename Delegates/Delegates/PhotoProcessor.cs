using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            //all the method points by the delegate called here..
            filterHandler.Invoke(photo);

            photo.Save();
        }
    }
}
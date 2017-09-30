using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelegate
{

    //the subscriber class 
   public class VideoEncoder
    {
        /// <summary>
        /// By addding the events you can create the various subscribers without changing
        /// the any lines of codein the publishers code(class).
        /// Delegate is nothing but a reference to a method or event handler.
        /// </summary>

        //1- Define the delegate
        //2- Define an event based on that delegate
        //3- Raise the event

        public delegate void VideoEncodedEvnetHandler(object source, EventArgs args);

        //Creating the event here based on that delegate..  
        public event VideoEncodedEvnetHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding the {video.title}...");
            Thread.Sleep(3000);

            //Raise the event here..
            OnVideoEncoded();
        }

        //Event method that raised
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }

    }
}

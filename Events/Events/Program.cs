using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EventsAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { title = "Video 1" };
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService();    //subscriber
            var textMessageService = new TextMessageService();  //subscriber


            //OnVideoEncoded is reference to the mail service method...
            //just like multicast
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textMessageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}

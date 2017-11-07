using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public class TextMessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Text message Service : Sending an TextMessage...");
        }
    }
}

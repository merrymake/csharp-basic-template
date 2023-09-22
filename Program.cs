using eu.merrymake.service.csharp;

namespace template.basic
{
    internal class Program
    {

        static void HandleHello(byte[] payloadBytes, Envelope envelope)
        {
            string payload = System.Text.Encoding.UTF8.GetString(payloadBytes);
            Merrymake.ReplyToOrigin($"Hello, {payload}!", MimeType.txt);
        }

        static void Main(string[] args)
        {
            Merrymake.Service(args)
                     .Handle("handleHello", HandleHello);
        }

    }
}
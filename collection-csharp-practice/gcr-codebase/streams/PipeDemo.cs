using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipeDemo
{
    static void Main()
    {
        AnonymousPipeServerStream server = new AnonymousPipeServerStream(PipeDirection.Out);
        AnonymousPipeClientStream client = new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle);

        Thread writer = new Thread(() =>
        {
            byte[] msg = Encoding.UTF8.GetBytes("Hello from Thread");
            server.Write(msg, 0, msg.Length);
        });

        Thread reader = new Thread(() =>
        {
            byte[] buffer = new byte[100];
            int bytesRead = client.Read(buffer, 0, buffer.Length);
            Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));
        });

        writer.Start();
        reader.Start();
    }
}

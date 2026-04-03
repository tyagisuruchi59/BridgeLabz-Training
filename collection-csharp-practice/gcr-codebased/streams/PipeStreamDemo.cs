using System;
using System.IO.Pipes;
using System.Threading;

class PipeStreamDemo
{
    static void Main()
    {
        var server = new AnonymousPipeServerStream(PipeDirection.Out);
        var client = new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle);

        new Thread(() =>
        {
            using (var writer = new StreamWriter(server))
            {
                writer.AutoFlush = true;
                writer.WriteLine("Hello from Writer");
            }
        }).Start();

        new Thread(() =>
        {
            using (var reader = new StreamReader(client))
            {
                Console.WriteLine(reader.ReadLine());
            }
        }).Start();
    }
}

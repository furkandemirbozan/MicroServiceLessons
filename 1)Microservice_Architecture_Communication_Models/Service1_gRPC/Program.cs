using Grpc.Net.Client;
using Service1_gRPC;

var chanel = GrpcChannel.ForAddress("https://localhost:7016");
var greeterClient = new Greeter.GreeterClient(chanel);
var response = greeterClient.SayHello(new HelloRequest
{
    Name = Console.ReadLine()
});

await Task.Run(async () =>
{
    while (await response.ResponseStream.MoveNext(new CancellationToken()))
    {
        Console.WriteLine($"Gelene mesaj :  {response.ResponseStream.Current.Message}");
    }
});

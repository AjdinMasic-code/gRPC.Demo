using System.Threading.Tasks;
using gRPC.Demo.Client;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7034");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

Console.WriteLine($"greetings: {reply.Message}");
Console.WriteLine("Press any key to exit....");

Console.ReadLine();

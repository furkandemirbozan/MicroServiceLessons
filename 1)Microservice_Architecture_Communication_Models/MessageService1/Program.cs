using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new();
factory.Uri = new Uri("amqps://lrwxleat:Y-P_U-BqIJLnMwkmq34PvtzucOCFGLkN@toad.rmq.cloudamqp.com/lrwxleat");


using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


channel.ExchangeDeclare(exchange: "direct-exchange-example", type: ExchangeType.Direct);


while (true)
{
    Console.WriteLine("Mesaj :  ");
    string message = Console.ReadLine();
    byte[] byteMessage = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(exchange: "direct-exchange-example", routingKey: "direct-queue-example",body: byteMessage);
}



Console.Read();
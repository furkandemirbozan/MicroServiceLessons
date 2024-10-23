using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;




ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://lrwxleat:Y-P_U-BqIJLnMwkmq34PvtzucOCFGLkN@toad.rmq.cloudamqp.com/lrwxleat");//coludamqp bağlantı adresi


using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


channel.ExchangeDeclare(exchange: "direct-exchange-example", type: ExchangeType.Direct);
string queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(queue: queueName, exchange: "direct-exchange-example", routingKey: "direct-queue-example");

EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
consumer.Received += (model, ea) =>
{
    string message = Encoding.UTF8.GetString(ea.Body.Span);
    Console.WriteLine(message);
};
Console.Read();
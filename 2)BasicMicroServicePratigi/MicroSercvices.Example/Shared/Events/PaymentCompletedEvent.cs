using Shared.Events.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events;

public class PaymentCompletedEvent:IEvent
{
    public Guid OrderId { get; set; }//mantık şu şekilde çalışacak, ödeme tamamlandığında bu event tetiklenecek ve order servisine gidip order'ın durumunu completed yapacak
}

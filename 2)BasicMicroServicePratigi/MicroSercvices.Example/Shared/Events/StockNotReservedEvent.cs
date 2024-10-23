using Shared.Events.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events;

public class StockNotReservedEvent:IEvent
{
    //bu id ile satın alan ve bu siaprişin id si başarısızdır demek istediğim yer burası
    public Guid BuyerId { get; set; }
    public Guid OrderId { get; set; }
    public string Message { get; set; }
}

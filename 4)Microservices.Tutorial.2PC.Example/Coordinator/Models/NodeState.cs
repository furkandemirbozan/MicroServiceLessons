using Coordinator.Enums;

namespace Coordinator.Models
{
    public record NodeState(Guid TransactionId)//TransactionId record'dan geliyor
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 1. aşamanın durumunu ifade ediyor.
        /// </summary>
        public ReadyType IsReady { get; set; }
        /// <summary>
        /// 2. aşamanın neticesinde işlemin başarılı tamamlanıp, tamamlanmadığını ifade ediyor.
        /// </summary>
        

        //Enum TransactionState 
        public TransactionState TransactionState { get; set; }
        //bire çok ilişki bir tane Node olabilir
        public Node Node { get; set; }
    }
}

namespace Coordinator.Models
{
    public record Node(string Name)
    {
        public Guid Id { get; set; }
        //public string Name { get; set; }

        //NodeState ile bire çok ilişki
        //birden fazla NodeState olabilir
        public ICollection<NodeState> NodeStates { get; set; }
    }
}

namespace ServiceApp.Models
{
    public enum ClassMachine
    {
        L1,
        L2,
        L3,
        L4
    }

    public class Machines
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassMachine ClassMachine { get; set; }
        public string SerialNumber { get; set; }
        public decimal Value { get; set; }
    }
}

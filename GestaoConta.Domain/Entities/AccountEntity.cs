namespace GestaoConta.Domain.Entities
{
    public class AccountEntity
    {
        public int Id { get; set; }
        public int CodeBank { get; set; }
        public int NumberAgency { get; set; }
        public int NumberAccount { get; set; }
        public int NumberDigit { get; set; }
        public string NameClient { get; set; }
        public int Document { get; set; }
    }
}
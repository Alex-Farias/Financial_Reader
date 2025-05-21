namespace Financial_Reader_Backend.Models
{
    class Transactions
    {
        public Transactions(int id, int value, string identifier, string description, PerDaily perDaily)
        {
            this.id = id;
            this.value = value;
            this.identifier = identifier;
            this.description = description;
            this.perDaily = perDaily;
        }
        public int id { get; set; }
        public int value { get; set; }
        public string identifier { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public PerDaily? perDaily { get; set; }
    }
}
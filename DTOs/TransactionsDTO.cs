namespace Financial_Reader_Backend.DTOs
{
    class TransactionsDTO
    {
        public TransactionsDTO(int id, int value, string identifier, string description, PerDailyDTO perDailyDTO)
        {
            this.id = id;
            this.value = value;
            this.identifier = identifier;
            this.description = description;
            this.perDailyDTO = perDailyDTO;
        }
        public int id { get; set; }
        public int value { get; set; }
        public string identifier { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public PerDailyDTO? perDailyDTO { get; set; }
    }
}
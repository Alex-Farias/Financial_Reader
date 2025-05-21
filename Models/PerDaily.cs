namespace Financial_Reader_Backend.Models
{
    class PerDaily
    {
        public PerDaily(int id, string description, PerWeekly perWeekly)
        {
            this.id = id;
            this.description = description;
            this.perWeekly = perWeekly;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public PerWeekly? perWeekly { get; set; }
    }
}
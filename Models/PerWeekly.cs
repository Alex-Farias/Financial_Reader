namespace Financial_Reader_Backend.Models
{
    class PerWeekly
    {
        public PerWeekly(int id, string description, PerMonthly perMonthly)
        {
            this.id = id;
            this.description = description;
            this.perMonthly = perMonthly;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public virtual PerMonthly? perMonthly { get; set; }
    }
}
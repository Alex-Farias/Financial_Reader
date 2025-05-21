namespace Financial_Reader_Backend.Models
{
    class PerMonthly
    {
        public PerMonthly(int id, string description, PerYearly perYearly)
        {
            this.id = id;
            this.description = description;
            this.perYearly = perYearly;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public virtual PerYearly? perYearly { get; set; }
    }
}
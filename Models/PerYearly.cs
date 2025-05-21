namespace Financial_Reader_Backend.Models
{
    class PerYearly
    {
        public PerYearly(int id, string description, User user)
        {
            this.id = id;
            this.description = description;
            this.user = user;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public virtual User? user { get; set; }
    }
}
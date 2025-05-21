namespace Financial_Reader_Backend.DTOs
{
    class PerDailyDTO
    {
        public PerDailyDTO(int id, string description, PerWeeklyDTO perWeeklyDTO)
        {
            this.id = id;
            this.description = description;
            this.perWeeklyDTO = perWeeklyDTO;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public PerWeeklyDTO? perWeeklyDTO { get; set; }
    }
}
namespace Financial_Reader_Backend.DTOs
{
    class PerMonthlyDTO
    {
        public PerMonthlyDTO(int id, string description, PerYearlyDTO perYearlyDTO)
        {
            this.id = id;
            this.description = description;
            this.perYearlyDTO = perYearlyDTO;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public virtual PerYearlyDTO? perYearlyDTO { get; set; }
    }
}
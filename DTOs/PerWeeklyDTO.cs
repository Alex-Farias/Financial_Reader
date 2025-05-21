namespace Financial_Reader_Backend.DTOs
{
    class PerWeeklyDTO
    {
        public PerWeeklyDTO(int id, string description, PerMonthlyDTO perMonthlyDTO)
        {
            this.id = id;
            this.description = description;
            this.perMonthlyDTO = perMonthlyDTO;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public virtual PerMonthlyDTO? perMonthlyDTO { get; set; }
    }
}
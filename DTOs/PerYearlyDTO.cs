namespace Financial_Reader_Backend.DTOs
{
    class PerYearlyDTO
    {
        public PerYearlyDTO(int id, string description, UserDTO userDTO)
        {
            this.id = id;
            this.description = description;
            this.userDTO = userDTO;
        }
        public int id { get; set; }
        public string description { get; set; } = string.Empty;
        public virtual UserDTO? userDTO { get; set; }
    }
}
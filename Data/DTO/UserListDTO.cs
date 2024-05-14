namespace TrasportoSanitario.Data.DTO
{
    public class UserListDTO
    {
        public string? Username { get; set; } = "";
        public string? Email { get; set; } = "";
        public string? Roles { get; set; } = "user";
        public string? Stato { get; set; } = "attivo";
    }
}

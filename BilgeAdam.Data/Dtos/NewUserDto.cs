namespace BilgeAdam.Data.Dtos
{
    public class NewUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int SecurityQuestionId { get; set; }
        public string Answer { get; set; }
    }
}

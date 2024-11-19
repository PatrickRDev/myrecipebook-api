namespace MyRecipeBook.Communication.Requests
{
    public class RequestRegisterUserJson
    {


        public string email { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string name { get; set; } = string.Empty;
    }
}

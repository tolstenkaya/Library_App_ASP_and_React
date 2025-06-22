namespace Library_App_ASP_and_React.Models
{
    public class ServiceResult
    {
        public bool state;
        public string message;

        public ServiceResult(bool state, string message)
        {
            this.state = state;
            this.message = message;
        }
    }
}

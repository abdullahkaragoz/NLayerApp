namespace NLayer.API.Middlewares
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message):base(message)
        {
            
        }
    }
}

namespace MegaventoryCart.Services.RestService
{
    public interface IRestService
    {
        Task<object> Post(string uri, object body);
    }
}

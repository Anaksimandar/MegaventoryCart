using MegaventoryCart.Models.SupplierClient;

namespace MegaventoryCart.Services.SupplierClient
{
    public interface ISupplierClientService
    {
        Task<object> UpdateSupplierClient(SupplierClientResult newSupplierClient);
    }
}

using SuperShop.Data.Entities;
using SuperShop.Models;

namespace SuperShop.Helper
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}

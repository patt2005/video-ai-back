using VideoBackend.BusinessLayer.Core;
using VideoBackend.BusinessLayer.Interfaces;

namespace VideoBackend.BusinessLayer;

public class BusinessLogic
{
    public BusinessLogic() { }

    public IProductLogic GetProductLogic()
    {
        return new ProductLogic();
    }
}
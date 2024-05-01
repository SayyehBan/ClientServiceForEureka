using Steeltoe.Management.Info;

namespace ClientServiceForEureka.Controllers;

public class MyInfoContributor : IInfoContributor
{
    public void Contribute(IInfoBuilder builder)
    {
        builder.WithInfo("MyInfo", new
        {
            Description = "میکروسرویس سایه بان",
            Name = "Order",
            email = "info@...."
        });
    }
}

public class ItemService : IItemService
{
    public decimal GetItemPrice(ContainerType containerType, IceCreamFlavor flavor)
    {
        double randomPrice;
        switch (containerType)
        {
            case ContainerType.Bowl:
                randomPrice = new Random().Next(7, 20);
                break;
            case ContainerType.Cone:
                randomPrice = new Random().Next(7, 20);
                break;
            default:
                randomPrice = 25;
                break;
        }

        randomPrice += new Random().NextDouble();
        return (decimal)randomPrice;
    }
}


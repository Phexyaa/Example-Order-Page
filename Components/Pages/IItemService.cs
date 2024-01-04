public interface IItemService
{
    decimal GetItemPrice(ContainerType containerType, IceCreamFlavor flavor);
}
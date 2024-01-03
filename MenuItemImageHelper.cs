public static class MenuItemImageHelper
{
    public static Dictionary<IceCreamType, string> BowlImages = new Dictionary<IceCreamType, string>()
    {
        { IceCreamType.Chocolate, "Images/Bowls/pistachio-bowl.jpeg" },
        { IceCreamType.Vanilla, "Images/Bowls/vanilla-bowl.jpeg" },
        { IceCreamType.Strawberry, "Images/Bowls/strawberry-bowl.jpeg" },
        { IceCreamType.Pistachio, "Images/Bowls/chocolate-bowl.jpeg" }
    };
    public static Dictionary<IceCreamType, string> ConeImages = new Dictionary<IceCreamType, string>()
    {
        { IceCreamType.Chocolate, "Images/Cones/pistachio-cone.jpeg" },
        { IceCreamType.Vanilla, "Images/Cones/vanilla-cone.jpeg" },
        { IceCreamType.Strawberry, "Images/Cones/strawberry-cone.jpeg" },
        { IceCreamType.Pistachio, "Images/Cones/chocolate-cone.jpeg" }
    };
    public static Dictionary<IceCreamType, string> BowlImageNames = new Dictionary<IceCreamType, string>()
    {
        { IceCreamType.Chocolate, "Choclate-Bowl" },
        { IceCreamType.Vanilla, "Vanilla-Bowl" },
        { IceCreamType.Strawberry, "Strawberry-Bowl" },
        { IceCreamType.Pistachio, "Pistachio-Bowl" },
    };
    public static Dictionary<IceCreamType, string> ConeImageNames = new Dictionary<IceCreamType, string>()
    {
        { IceCreamType.Chocolate, "Choclate-Cone" },
        { IceCreamType.Vanilla, "Vanilla-Cone" },
        { IceCreamType.Strawberry, "Strawberry-Cone" },
        { IceCreamType.Pistachio, "Pistachio-Cone" },
    };
}


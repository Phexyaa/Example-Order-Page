public static class ImageHelper
{
    public static Dictionary<IceCreamType, string> ImageFilePaths { get; set; } = new Dictionary<IceCreamType, string>()
    {
        {IceCreamType.ChocolateBowl, "Images/Bowls/chocolate-bowl.jpeg" },
        {IceCreamType.StrawberryBowl, "Images/Bowls/strawberry-bowl.jpeg" },
        {IceCreamType.VanillaBowl, "Images/Bowls/vanilla-bowl.jpeg" },
        {IceCreamType.PistachioBowl, "Images/Bowls/pistachio-bowl.jpeg" },
        {IceCreamType.ChocolateBowl, "Images/Cones/chocolate-cone.jpeg" },
        {IceCreamType.StrawberryBowl, "Images/Cones/strawberry-cone.jpeg" },
        {IceCreamType.VanillaBowl, "Images/Cones/vanilla-cone.jpeg" },
        {IceCreamType.PistachioBowl, "Images/Cones/pistachio-cone.jpeg" },
    };
}


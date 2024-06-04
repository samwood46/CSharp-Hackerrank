public class MegaStore
{
    public enum DiscountType
    {
        Standard,
        Seasonal,
        Weight
    }

    public static double GetDiscountedPrice(double cartWeight,
                                            double totalPrice,
                                            DiscountType discountType)
    {
        double discountedPrice = 0;
        // seasonal
        if (discountType == DiscountType.Seasonal)
        {
            discountedPrice = totalPrice * 0.88;
        }


            //weight
        if (discountType == DiscountType.Weight)
        {
            if (cartWeight <= 10)
                discountedPrice = totalPrice * 0.94;

            if (cartWeight > 10)
                discountedPrice = totalPrice * 0.82;
        }

        //standard
        if (discountType == DiscountType.Standard) { 
            discountedPrice = totalPrice * 0.94;
        }
        return discountedPrice;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GetDiscountedPrice(12, 100, DiscountType.Weight));
    }
}
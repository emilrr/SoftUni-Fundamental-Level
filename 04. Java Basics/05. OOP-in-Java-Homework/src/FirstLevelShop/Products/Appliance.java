package FirstLevelShop.Products;

import FirstLevelShop.Enum.AgeRestriction;
import FirstLevelShop.Enum.GuaranteePeriod;

import java.math.BigDecimal;

public class Appliance extends ElectronicsProduct{
    private final int totalQuantityForIncreasedPrice = 50;
    private final BigDecimal plusPercentage = new BigDecimal(5);

    public Appliance(String name, BigDecimal price, double quantity) {
        super(name, price, quantity, AgeRestriction.ADULT, GuaranteePeriod.APPLIANCE);
        this.setPrice(price);
    }

    @Override
    public void setPrice(BigDecimal price) {
        if (this.getQuantity() <= totalQuantityForIncreasedPrice) {
            super.setPrice(price.add(percentage(price, plusPercentage)));
        }
    }
}
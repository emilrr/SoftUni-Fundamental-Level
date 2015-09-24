package FirstLevelShop.Products;

import FirstLevelShop.Enum.AgeRestriction;
import FirstLevelShop.Enum.GuaranteePeriod;

import java.math.BigDecimal;

public class Computer extends ElectronicsProduct {
    private final int totalQuantityForReducedPrice = 1000;
    private final BigDecimal offPercentage = new BigDecimal(5);

    public Computer(String name, BigDecimal price, double quantity) {
        super(name, price, quantity, AgeRestriction.TEENAGER, GuaranteePeriod.COMPUTER);
        this.setPrice(price);
    }

    @Override
    public void setPrice(BigDecimal price) {
        if (this.getQuantity() >= totalQuantityForReducedPrice) {
            super.setPrice(price.subtract(percentage(price, offPercentage)));
        }
    }
}
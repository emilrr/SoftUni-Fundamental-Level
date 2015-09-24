package FirstLevelShop.Products;

import FirstLevelShop.Enum.AgeRestriction;
import FirstLevelShop.Interface.Expirable;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class FoodProduct extends Product implements Expirable{
    private final int minExpirationDays = 15;
    private final BigDecimal offPercentage = new BigDecimal(30);
    private LocalDate expirationDate;

    public FoodProduct(String name, BigDecimal price, double quantity, AgeRestriction ageRestriction, LocalDate expirationDate) {
        super(name, price, quantity, ageRestriction);

        this.setExpirationDate(expirationDate);
        this.setPrice(price);
    }

    public FoodProduct(String name, BigDecimal price, double quantity, AgeRestriction ageRestriction) {
        this(name, price, quantity, ageRestriction, LocalDate.MAX);
    }

    @Override
    public LocalDate getExpirationDate() {
        return expirationDate;
    }

    public void setExpirationDate(LocalDate expirationDate) {
        this.expirationDate = expirationDate;
    }

    @Override
    public void setPrice(BigDecimal price) {
        if (this.getDatesDifference() <= minExpirationDays) {
            super.setPrice(price.subtract(percentage(price, offPercentage)));
        }
    }

    private long getDatesDifference() {
        //LocalDate start = LocalDate.parse(this.getExpirationDate().toString());
        long diff = ChronoUnit.DAYS.between(LocalDate.now(), this.getExpirationDate());
        return diff;
    }
}
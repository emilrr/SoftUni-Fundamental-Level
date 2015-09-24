package FirstLevelShop;

import FirstLevelShop.Interface.Expirable;
import FirstLevelShop.Enum.AgeRestriction;
import FirstLevelShop.Products.*;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Comparator;

public class Shop {
    public static void main(String[] args) {
        FoodProduct cigars = new FoodProduct(
                "420 Blaze it fgt",
                new BigDecimal(6.90),
                1400,
                AgeRestriction.ADULT,
                LocalDate.of(2015, 9, 20));
        Customer pecata = new Customer("Pecata", 17, new BigDecimal(30.00));
        Customer gopeto = new Customer("Gopeto", 18, new BigDecimal(0.44));

        try {
            //PurchaseManager.processPurchase(cigars, pecata);
            PurchaseManager.processPurchase(cigars, gopeto);
        } catch (Exception ex) {
            System.out.println(ex.getMessage() );
        }

        ArrayList<Product> products = new ArrayList<>();
        products.add(cigars);
        Computer computer = new Computer("Home", new BigDecimal(1000), 15);
        Computer laptop = new Computer("Laptop", new BigDecimal(1500), 12);
        Appliance dishWasher = new Appliance("DishWasher", new BigDecimal(500), 10);
        products.add(computer);
        products.add(laptop);
        products.add(dishWasher);
        FoodProduct bread = new FoodProduct(
                "Franzela",
                new BigDecimal(0.80),
                50,
                AgeRestriction.NONE,
                LocalDate.of(2015, 9, 19));
        products.add(bread);
        Appliance kitchenKnife = new Appliance("Knife", new BigDecimal(50), 200);
        products.add(kitchenKnife);
        String name = products.stream()
                .filter(p -> p instanceof Expirable)
                .map(p -> ((FoodProduct) p))
                .sorted(Comparator.comparing(p -> p.getExpirationDate()))
                .findFirst()
                .get().getName();
        System.out.println(name);

        products.stream()
                .filter(p -> p.getAgeRestriction() == AgeRestriction.ADULT)
                .sorted(Comparator.comparing(p -> p.getPrice()))
                .forEach(p -> System.out.println(p.getName()));
    }
}
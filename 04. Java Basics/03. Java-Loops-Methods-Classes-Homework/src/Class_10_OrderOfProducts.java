import java.io.*;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;

public class Class_10_OrderOfProducts {
    public static void main(String[] args) throws IOException {
        try {
            FileReader productsReader = new FileReader("C:\\...\\Products.txt");
            BufferedReader reader = new BufferedReader(productsReader);

            ArrayList<Product> products = new ArrayList<>();
            String line = reader.readLine();

            while (line != null) {
                String[] splitLine = line.split(" ");
                String name = splitLine[0];
                BigDecimal price = new BigDecimal(splitLine[1]);

                Product currentProduct = new Product(price, name);
                products.add(currentProduct);

                line = reader.readLine();
            }

            FileReader ordersReader = new FileReader("C:\\....\\Order.txt");
            BufferedReader readerOrder= new BufferedReader(ordersReader);

            String lineOrder = readerOrder.readLine();
            BigDecimal totalPrice = BigDecimal.ZERO;

            while (lineOrder != null) {
                String[] splitLine = lineOrder.split(" ");
                BigDecimal quantity = new BigDecimal(splitLine[0]);
                String nameProduct = splitLine[1];

                for (Product product : products) {
                    if (product.getName().equals(nameProduct)) {
                        BigDecimal currentPrice = (product.getPrice().multiply(quantity));
                        totalPrice = totalPrice.add(currentPrice);
                    }
                }

                lineOrder = readerOrder.readLine();
            }

            File outputWriter = new File("C:\\...\\orderProducts_output.txt");
            PrintStream writer = new PrintStream(outputWriter);

            writer.println(String.format("%.1f", totalPrice));

            productsReader.close();
            ordersReader.close();
            writer.close();

        } catch (FileNotFoundException e) {
            System.out.println("Error");
        }
    }
}

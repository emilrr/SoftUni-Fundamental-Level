import java.io.*;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;

public class Class_09_ListOfProducts {
    public static void main(String[] args) throws IOException {
        try {
            FileReader inputReader = new FileReader("C:\\...\\listProducts_input.txt");
            BufferedReader reader = new BufferedReader(inputReader);

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

            Collections.sort(products);

            File outputWriter = new File("listProducts_output.txt");
            PrintStream writer = new PrintStream(outputWriter);

            for (Product product : products) {
                writer.println(product.getPrice() + " " + product.getName());
            }


        } catch (FileNotFoundException e) {
            System.out.println("Error");
        }
    }
}

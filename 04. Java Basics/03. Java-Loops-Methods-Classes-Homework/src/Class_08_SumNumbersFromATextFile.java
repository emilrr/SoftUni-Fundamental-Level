import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.FileReader;

public class Class_08_SumNumbersFromATextFile {
    public static void main(String[] args)  throws IOException{
        try {
            FileReader fileReader = new FileReader("C:\\....\\input.txt");
            BufferedReader bufferedReader = new BufferedReader(fileReader);

            long sum = 0;

            String line = bufferedReader.readLine();

            while (line != null) {
                sum += Integer.parseInt(line);
                line = bufferedReader.readLine();
            }

            System.out.println(sum);

            bufferedReader.close();
        } catch (FileNotFoundException e) {
            System.out.println("Error");

        }
    }
}

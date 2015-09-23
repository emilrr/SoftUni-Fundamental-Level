import java.util.ArrayList;
import java.util.Scanner;

public class Class_01_SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int startNumber = input.nextInt();
        int endNumber = input.nextInt();

        for (int i = startNumber; i <= endNumber; i++) {

            StringBuilder sb = new StringBuilder();
            sb.append("");
            sb.append(i);
            String numberBeforeConvert = sb.toString();
            String numberAfterConvert = sb.reverse().toString();

            if(numberBeforeConvert.equals(numberAfterConvert)){
                System.out.printf("%s ", numberBeforeConvert);
            }
        }
    }
}

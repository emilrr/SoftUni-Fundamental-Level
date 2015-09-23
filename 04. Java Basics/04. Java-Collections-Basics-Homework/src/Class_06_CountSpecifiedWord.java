import java.util.Scanner;

public class Class_06_CountSpecifiedWord {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String text[] = scanner.nextLine().split("[\\W]+");
        String word = scanner.nextLine();
        int counter = 0;

        for (int i = 0; i < text.length; i++) {
            if(text[i].equalsIgnoreCase(word)){
                counter++;
            }

        }

        System.out.println(counter);
        scanner.close();
    }
}

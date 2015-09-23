import java.util.Scanner;

public class Class_14_StuckNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        scanner.nextLine();
        String numbers = scanner.nextLine().trim();
        String numberArray[]  = numbers.split(" ");

        boolean isFound = false;

        for (int i = 0; i < numberArray.length; i++) {
            for (String second : numberArray) {
                for (String third : numberArray) {
                    for (String fourth : numberArray) {

                        String a = numberArray[i].toString();
                        String b = second;
                        String c = third;
                        String d = fourth;

                        String firstSubstring = a+b;
                        String secondSubstring = c+d;

                        if (!(a.equals(b)) && !(a.equals(c)) && !(a.equals(d)) &&
                                !(b.equals(c)) && !(b.equals(d)) && !(c.equals(d))
                                && firstSubstring.equals(secondSubstring))
                        {
                            System.out.printf("%s|%s==%s|%s", a, b, c, d);
                            System.out.println();
                            isFound = true;
                        }

                    }
                }
            }
        }

        if (!isFound)
        {
            System.out.println("No");
        }
    }
}

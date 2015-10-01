import java.util.Scanner;

public class Problem_02_TerroristsWin {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        char[] result = text.toCharArray();

        while (new String(result).indexOf('|') != -1) {
            int startIndex = new String(result).indexOf('|');
            result[startIndex] = '.';
            int endIndex = new String(result).indexOf('|');
            result[endIndex] = '.';

            String bomb = new String(result).substring(startIndex + 1, endIndex);

            int sum = 0;
            for (Character ch : bomb.toCharArray()) {
                sum += ch;
            }

            int bombDamage = sum % 10;

            int startArea = Math.max(0, startIndex - bombDamage);
            int endArea = Math.min(text.length() - 1, endIndex + bombDamage);

            for (int i = startArea; i <= endArea; i++) {
                result[i] = '.';
            }

        }

        System.out.println(new String(result));
    }
}

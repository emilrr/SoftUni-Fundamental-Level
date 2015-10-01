import java.util.Scanner;

public class Problem_01_Enigma {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int lines = Integer.parseInt(input.nextLine());

        while (lines > 0) {
            String stringExpression = input.nextLine();
            String withoutNumbersAndWhitespace = stringExpression.replaceAll("([0-9]+|\\s+)", "");
            int halfLength = withoutNumbersAndWhitespace.length() / 2;

            char[] charExpression = stringExpression.toCharArray();
            char[] result = new char[stringExpression.length()];

            for (int i = 0; i < charExpression.length; i++) {
                if (!Character.isDigit(charExpression[i]) && charExpression[i] != ' ') {
                    int letterBefore = (int) charExpression[i];
                    int letterAfter = letterBefore + halfLength;
                    charExpression[i] = (char)letterAfter;
                }

                result[i] = charExpression[i];
            }

            System.out.println(result);
            lines--;
        }
    }
}
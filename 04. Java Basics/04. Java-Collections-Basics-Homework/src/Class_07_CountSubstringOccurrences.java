import java.util.Scanner;

public class Class_07_CountSubstringOccurrences {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text[] = scanner.nextLine().split(" ");
        String word = scanner.nextLine().toLowerCase();

        int count = 0;

        for (int i = 0; i < text.length; i++) {

            String wordFromText = text[i].toLowerCase();

            for (int j = 0; j <= wordFromText.length() - word.length(); j++) {

                String substringWord = wordFromText.substring(j, word.length() + j);
                if(substringWord.equals(word)){
                    count++;
                }
            }
        }

        System.out.println(count);
        scanner.close();
    }
}

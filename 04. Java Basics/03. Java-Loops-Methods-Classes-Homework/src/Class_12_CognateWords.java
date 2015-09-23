import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Pattern;

public class Class_12_CognateWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();
        String wordsArray[] = input.split("\\s*[^a-zA-Z]+\\s*");

        ArrayList<String> cognateWordsList = new ArrayList<>();
        boolean isFind = false;
        
        for (int i = 0; i < wordsArray.length; i++) {
            for (String word : wordsArray) {

                String firstWord = wordsArray[i] + word;

                for (String secondWord : wordsArray) {
                    

                    if(firstWord.equals(secondWord) && !cognateWordsList.contains(secondWord)){
                        System.out.printf("%s|%s=%s", wordsArray[i], word, secondWord);
                        System.out.println();
                        isFind = true;
                        cognateWordsList.add(secondWord);
                    }
                }
            }
        }

        if(!isFind){
            System.out.println("No");
        }
    }
}

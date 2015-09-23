import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Class_14_ExamScore {

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);
        scanner.nextLine();
        scanner.nextLine();
        scanner.nextLine();

        TreeMap<Integer, TreeMap<String, Double>> studentInformation = new TreeMap<>();

        String line = scanner.nextLine();

        while (true) {
            if (line.charAt(0) == '-') {
                break;
            }

            String replaceLine = line.replace("|", "");
            String splitLine[] = replaceLine.split("\\s+\\s+");

            String name = splitLine[0].trim();
            Integer score = Integer.parseInt(splitLine[1]);
            Double grade = Double.parseDouble(splitLine[2]);

            if (!studentInformation.containsKey(score)) {
                studentInformation.put(score, new TreeMap<>());
            }
            studentInformation.get(score).put(name, grade);

            line = scanner.nextLine();
        }

        for (Integer score : studentInformation.keySet()) {
            System.out.print(score + " -> ");
            System.out.print(studentInformation.get(score).keySet() + "; ");

            double sumOfGrade = 0;

            for (double grade : studentInformation.get(score).values()) {
                sumOfGrade += grade;
            }

            double averageGrade = sumOfGrade / studentInformation.get(score).values().size();
            System.out.println(String.format("avg=%.2f", averageGrade));
        }
    }
}
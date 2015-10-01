import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;

public class Problem_04_SchoolSystem {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        int n = Integer.parseInt(scn.nextLine());

        TreeMap<String, TreeMap<String, ArrayList<Double>>> students = new TreeMap<>();

        while (n > 0) {
            String[] line = scn.nextLine().split(" ");
            String fullName = line[0] + " " + line[1];
            String subject = line[2];
            Double score = Double.parseDouble(line[3]);

            TreeMap<String, ArrayList<Double>> currentStudent = new TreeMap<>();

            if (!students.containsKey(fullName)) {
                ArrayList<Double> subjectStudent = new ArrayList<Double>();
                subjectStudent.add(score);
                currentStudent.put(subject, subjectStudent);
                students.put(fullName, currentStudent);
            } else if (!students.get(fullName).containsKey(subject)) {
                ArrayList<Double> subjectStudent = new ArrayList<Double>();
                subjectStudent.add(score);
                students.get(fullName).put(subject, subjectStudent);
            } else {
                students.get(fullName).get(subject).add(score);
            }

            n--;
        }

        printData(students);
    }

    private static void printData(TreeMap<String, TreeMap<String, ArrayList<Double>>> students) {
        for (String name : students.keySet()) {
            System.out.printf("%s: ", name);
            String ipOutput = "[";
            for (String subject : students.get(name).keySet()) {

                int countOfMarks = students.get(name).get(subject).size();
                double sum = 0;
                for (int i = 0; i < countOfMarks; i++) {
                    sum += students.get(name).get(subject).get(i);
                }
                double avg = sum / countOfMarks;


                ipOutput += String.format("%s - %.2f, ", subject, avg);
            }
            ipOutput = ipOutput.substring(0, ipOutput.length() - 2) + ']';
            System.out.println(ipOutput);
        }
    }
}

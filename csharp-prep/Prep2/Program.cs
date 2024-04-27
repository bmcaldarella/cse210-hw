using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter your grade percentage: ");
    int percentage = Convert.ToInt32(Console.ReadLine());

    string letter = "";

    if (percentage >= 90) {
      letter = "A";
    } else if (percentage >= 80) {
      letter = "B";
    } else if (percentage >= 70) {
      letter = "C";
    } else if (percentage >= 60) {
      letter = "D";
    } else {
      letter = "F";
    }

    if (percentage >= 70) {
      Console.WriteLine("Congratulations! You passed the class.");
    } else {
      Console.WriteLine("Keep up the good work! You'll get it next time.");
    }

    Console.WriteLine("Your grade is: " + letter);

    string sign = "";
    int lastDigit = percentage % 10; 

    if (lastDigit >= 7 && percentage != 100) {
      sign = "+";
    } else if (lastDigit < 3 || percentage == 100) {
      sign = "-";
    }

    if (letter == "A" && sign == "+") {
      sign = "";
    } else if (letter == "F" && sign == "+") {
      sign = "";
    }

    Console.WriteLine("Your grade with sign is: " + letter + sign);
  }
}

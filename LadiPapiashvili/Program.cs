// first TEST

// using System;

// class Program {
//   static void Main() {
//     int attempts = 0;
//     string username = "ladi";
//     string password = "ladi";
//     while (true) {
//       Console.Write("Enter username: ");
//       string? inputUsername = Console.ReadLine();
//       Console.Write("Enter password: ");
//       string? inputPassword = Console.ReadLine();

//       if (string.Equals(inputUsername, username, StringComparison.OrdinalIgnoreCase) &&
//           string.Equals(inputPassword, password, StringComparison.Ordinal)) {
//         Console.WriteLine("Success!");
//         break;
//       } else {
//         attempts++;
//         Console.WriteLine("Invalid username or password.");
//         if (attempts >= 5) {
//           Console.WriteLine("You have exceeded the maximum number of attempts.");
//           break;
//         }
//       }
//     }
//   }
// }





// Second TEST

// using System;

// class Program {
//   static void Main() {
//     Console.Write("Enter a number: ");
//     int number = int.Parse(Console.ReadLine()!);
//     string binary = Convert.ToString(number, 2);
//     Console.WriteLine($"The binary representation of {number} is: {binary}");
//   }
// }




// Third TEST

using System;

class Program {
  static void Main() {
    double length = 2.5;
    double width = 3.0;
    double height = 4.0;

    double area = CalculateArea(length, width);
    double volume = CalculateVolume(length, width, height);

    Console.WriteLine($"The area of the box is {area}");
    Console.WriteLine($"The volume of the box is {volume}");
  }

  static double CalculateArea(double length, double width) {
    return length * width;
  }

  static double CalculateVolume(double length, double width, double height) {
    return length * width * height;
  }
}

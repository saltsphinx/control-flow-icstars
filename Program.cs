int score = 85;
char grade;

grade = score >= 90 ? 'A' : score >= 80 ? 'B' : score >= 70 ? 'C' : score >= 60 ? 'D' : 'F';

Console.WriteLine("Your grade is: " + grade);

// switch (score)
// {
//     case >= 90:
//         grade = 'A';
//         break;
//     case >= 80:
//         grade = 'B';
//         break;
//     case >= 70:
//         grade = 'C';
//         break;
//     case >= 60:
//         grade = 'D';
//         break;
//     default:
//         grade = 'F';
//         break;
// }

// Console.WriteLine("Your grade is: " + grade);


// if (score >= 90) {
//     grade = 'A';
// }
// else if (score >= 80) {
//     grade = 'B';
// }
// else if (score >= 70) {
//     grade = 'C';
// }
// else if (score >= 60) {
//     grade = 'D';
// }
// else {
//     grade = 'F';
// }

// Console.WriteLine("Your grade is: " + grade);

// int score = 85;
// char grade;

// if (score >= 90) {
//     grade = 'A';
// }
// else if (score >= 80) {
//     grade = 'B';
// }
// else if (score >= 70) {
//     grade = 'C';
// }
// else if (score >= 60) {
//     grade = 'D';
// }
// else {
//     grade = 'F';
// }

// Console.WriteLine("Your grade is: " + grade);
// int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7};

// foreach (int num in numbers)
// {
//     Console.WriteLine(num);
// }

// int number = 10;
// switch (number) {
//     case 1:
//         Console.WriteLine("Number is one.");
//         break;
//     case 2:
//         Console.WriteLine("Number is two.");
//         break;
//     case 3:
//         Console.WriteLine("Number is three.");
//         break;
//     default:
//         Console.WriteLine("Number is not one, two, or three.");
//         break;
// }

// int number = 10;
// if (number == 1) {
//     Console.WriteLine("Number is one");
// } else if (number == 2) {
//     Console.WriteLine("Number is two");
// } else if (number == 3) {
//     Console.WriteLine("Number is three");
// } else {
//     Console.WriteLine("Number is not one, two or, three");
// }

// bool hasPermission = true;
// bool isAdmin = false;
// if (hasPermission && isAdmin) {
//     Console.WriteLine("Access granted.");
// } else {
//     Console.WriteLine("Access denied.");
// }
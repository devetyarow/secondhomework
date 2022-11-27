//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number, a week day: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(this day - day of rest) -> yeaaap");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("this dont day of week");
  }
  else Console.WriteLine("(this day - day of job) -> noooo");
}

CheckingTheDayOfTheWeek(dayNumber);
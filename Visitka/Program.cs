string fullName = "Иванов Иван Иванович";
string group = "ИСП-252";
int course = 2;
string specialty = "09.02.07";
// переменные для подсчета средней оценки
double grade1 = 4.5;
double grade2 = 4.0;
double grade3 = 4.5;
bool stip;
int totalWeeks = 20;
int weeksPassed = 2;
int weeksRemaining;
// константа минимальный средний балл для получения стипендии
const double mingrade = 4.0;
double grade = (grade1 + grade2 + grade3) / 3;
weeksRemaining = totalWeeks - weeksPassed;
// сравнение положена ли стипендия 
stip = grade >= mingrade;

Console.WriteLine("===== ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА =====");
Console.WriteLine();
Console.WriteLine($"ФИО:        {fullName}");
Console.WriteLine($"Группа:     {group}");
Console.WriteLine($"Курс:       {course}");
Console.WriteLine($"Специальность: {specialty}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {grade}");
Console.WriteLine($"Стипендия положена (>= 4): {stip}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {weeksRemaining}");
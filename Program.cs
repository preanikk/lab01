// string name = "Максим";
// string groupname = "isp252";
// int coursenumber = 2;
// double averageGrade = 4.5;
// bool IsStudent = true;

// Console.WriteLine($"Студент: {name}"); // имя студента
// Console.WriteLine($"Группа: {groupname}");// название группы
// Console.WriteLine($"Курс: {coursenumber}");
// Console.WriteLine($"Средняя оценка: {averageGrade}");
// Console.WriteLine($"Проверка на студента: {IsStudent}");

// Console.WriteLine("Ремонт комнаты");
// double roomWidth = 3.5;
// double roomLength = 4.2;
// double RoomArea = roomWidth * roomLength;
// double roomPerimeter = (roomWidth + roomLength) * 2; // поиск периметра
// Console.WriteLine($"Ширина - {roomWidth} м, длина - {roomLength} м");
// Console.WriteLine($"Периметр - {roomPerimeter}");
// Console.WriteLine($"Площадь - {RoomArea}");

/*
мы посчитали 
периметр
*/
using System;

// string firstname = "Денис";
// string lastName = "Леонтьев";
// string fullNameContact = firstname + " " + lastName;
// string fullNameIntrep = $"{firstname}{lastName}";
// string fillNameContactMethod = string.Concat(firstname, " ", lastName);
// Console.WriteLine(fullNameContact);
// Console.WriteLine(fullNameIntrep);
// Console.WriteLine(fillNameContactMethod);


// const double VatRate = 0.2;
// const string CollgeName = "ВФ ВолГУ";
// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);
// Console.WriteLine($"Учебное заведение: {CollgeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, c НДС ({VatRate:P0}):{priceWithVat}");

// int lapTopPrice = 65000;
// int monthsCount = 12;
// double interestRate = 0.08;

// double totalWithInterest = lapTopPrice * (1 + interestRate);
// double monthlyPayment = totalWithInterest / monthsCount;

// Console.WriteLine($"Цена ноутбука: {lapTopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб");
// Console.WriteLine($"Платеж в месяц: {monthlyPayment} руб.");


// string fullName = "Иванов Иван Иванович";
// string group = "ИСП-252";
// int course = 2;
// string specialty = "09.02.07";
// // переменные для подсчета средней оценки
// double grade1 = 4.5;
// double grade2 = 4.0;
// double grade3 = 4.5;
// bool stip;
// int totalWeeks = 20;
// int weeksPassed = 2;
// int weeksRemaining;
// // константа минимальный средний балл для получения стипендии
// const double mingrade = 4.0;
// double grade = (grade1 + grade2 + grade3) / 3;
// weeksRemaining = totalWeeks - weeksPassed;
// // сравнение положена ли стипендия 
// stip = grade >= mingrade;

// Console.WriteLine("===== ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА =====");
// Console.WriteLine();
// Console.WriteLine($"ФИО:        {fullName}");
// Console.WriteLine($"Группа:     {group}");
// Console.WriteLine($"Курс:       {course}");
// Console.WriteLine($"Специальность: {specialty}");
// Console.WriteLine();
// Console.WriteLine($"Средний балл за 3 работы: {grade}");
// Console.WriteLine($"Стипендия положена (>= 4): {stip}");
// Console.WriteLine();
// Console.WriteLine($"Учебных недель осталось в семестре: {weeksRemaining}");


// double celsius = 36.6;

// const double fahrenheit1 = 32;
// const double kelvin1 = 273.15;

// double fahrenheit = celsius * 9/5 + fahrenheit1;
// double kelvin = celsius + kelvin1;

// Console.WriteLine($"{celsius}C = {fahrenheit}F = {kelvin}K");



int totalMinutes = 500;
int minutesPerLesson = 45;

int ostatok = totalMinutes % minutesPerLesson;
int lessons = totalMinutes / minutesPerLesson;

Console.WriteLine($"{totalMinutes} минут = {lessons} полных занятий + {ostatok} минут.");
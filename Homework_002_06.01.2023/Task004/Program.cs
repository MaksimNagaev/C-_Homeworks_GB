﻿// Задача необязательная 2: по желанию идет за 2 необязательных

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, 
// когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с 
// правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 100 человек.

Console.WriteLine("Введите целое неотрицательное число");
int x = Convert.ToInt32(Console.ReadLine());
int a = x % 100;
if (a >= 5 && a < 21) Console.WriteLine($"В комнате {x} программистов");
else if (a == 0 || a > 4) Console.WriteLine($"В комнате {x} программистов");
else if (a == 1) Console.WriteLine($"В комнате {x} программист");
else if (a < 0) Console.WriteLine("В комнате должны быть программисты, но их нет!");
else Console.WriteLine($"В комнате {x} программиста");

﻿// E. Кодовый замок

// ввод
// стандартный ввод
// вывод
// стандартный вывод
// Скрудж МакДак держит свои самые сокровенные сбережения в сейфе, защищенном кодовым замком. Каждый раз, когда он кладет туда новые честно заработанные драгоценности, 
// он вынужден открывать замок.

// Кодовый замок представляет собой n вращающихся дисков с написанными на них цифрами от 0 до 9. Скрудж МакДак должен повернуть некоторые из дисков так, 
// чтобы последовательность цифр на дисках образовала секретную комбинацию. За одно действие он может прокрутить один из дисков на одну цифру вперед или назад. 
// В частности, за одно действие можно перейти от цифры 0 к цифре 9 и наоборот. Какое минимальное количество действий ему для этого потребуется?

// Входные данные
// В первой строке записано единственное целое число n (1 ≤ n ≤ 1000) — количество дисков на кодовом замке.
// Во второй строке записана строка из n цифр — исходное положение дисков.
// В третьей строке записана строка из n цифр — комбинация Скруджа МакДака, открывающая замок.
// Выходные данные
// Выведите единственное целое число — минимальное количество действий, за которое Скрудж МакДак откроет замок.
// Примеры
// входные данные
// Скопировать
// 5
// 82195
// 64723
// выходные данные
// Скопировать
// 13
// Примечание
// В примере требуется 13 действий:
// •	1 диск:  
// •	2 диск:  
// •	3 диск:  
// •	4 диск:  
// •	5 диск:  

int n = Convert.ToInt32(Console.ReadLine()); //( n (1 ≤ n ≤ 1000) — количество дисков на кодовом замке.
string originalState = Console.ReadLine() ?? "0"; // строка из n цифр — исходное положение дисков.
string code = Console.ReadLine() ?? "0"; //строка из n цифр — комбинация Скруджа МакДака, открывающая замок.

int uniqueDigitsCode = 10, steps = 0, difference;
for (int i = 0; i < n; i++)
{
    difference = Math.Abs(Convert.ToInt32(originalState[i]) - Convert.ToInt32(code[i]));
    steps += difference < uniqueDigitsCode - difference ? difference : uniqueDigitsCode - difference;
}

Console.WriteLine(steps);
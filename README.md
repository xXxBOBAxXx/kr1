Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами. 

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

1. string str = Console.ReadLine() ?? "";
считывание, введенной в терминал строку 

2. string[] strs = str.Split(',');
создание из введенной строки массив строк, делящийся за счет введенных запятых, пример:
["hello"]
[ "2"]
[ "world"]
[ ":-)"]

3. int cntSpace = 0, cntFirstPrint = 0;
создание переменной - счетчика прохождения первой подстроки через цикл, 
а так же переменной - счетчика первого вывода подстроки, подходящей под условие

4. foreach (string rslt in strs)
создание новвого массива [rslt], 
перенося в него каждую подстроку проверяя на выполнение условя

6. if (rslt.Length <= 5 + cntSpace)
проверка условияе, где [5] учитывает два лишних символа ["] в каждой подстроке,
а [cntSpace] учитывает лишний пробел, оставшийся во всех подстроках, кроме первой

8. if (cntFirstPrint == 1) Console.Write("," + rslt);
вывод [,] и подстроки подходящей под условие, 
если до этого какая либо подстрока уже выводилась, например [, ":-)"]

9. else if (cntSpace == 1) Console.Write(rslt.Substring(1));
первый вывод любой подстроки подходящей под условие, после первого цикла,
игнорируя пробел, пример ["2"]

10. else Console.Write(rslt);
вывод первой подстроки, если она подходит под условие

11. cntFirstPrint = 1;
отмечает первый вавод любой подстроки 

13. cntSpace = 1;
отмечает первое прохождение цикла

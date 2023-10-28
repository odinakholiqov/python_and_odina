# EXAM FOR WEEK 2
## RULES:
> No interner, no help to each other!
> Make one file and place all your work there (e.g. odina_kholiqov.py)
> Send the file at 
> You have 2 hours only

### 1 Question
Write a program to determine whether a given year is a leap year / Напишите программу, чтобы определить, является ли данный год високосным / Барномаи нависед, то муайян кунед, ки соли додашуда соли кабиса аст.

### 2 Question
Write program to print yesterday, today, tomorrow / Барномаи нависед, то дирӯз, имрӯз, фардо чоп кунед / Напишите программу для печати вчера, сегодня, завтра.

### 3 Question
Write a program to subtract five days from the current date / Напишите программу, которая вычитает пять дней из текущей даты.
```
Input: 28.10.2023
Output: 2.11.2023
```

### 4 Question
Write a program to calculate the number of days between two dates / Напишите программу на Python для расчета количества дней между двумя датами

### 5 Question
Write a program to count a number of words, digits, and symbols in a file / Напишите программу для подсчета количества слов, цифр и символов в файле

### 6 Question
Write a program to read the first n lines of a file / Напишите программу для чтения первых n строк файла.

### 7 Question
Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.

Учитывая массив временных интервалов совещаний, состоящий из времени начала и окончания [[s1,e1],[s2,e2],...] (si < ei), найдите минимальное необходимое количество конференц-залов.

Бо назардошти як қатор фосилаҳои вақти вохӯрӣ, ки аз вақти оғоз ва анҷоми он [[s1,e1],[s2,e2],...] (si < ei) иборат аст, шумораи ҳадди ақали утоқҳои конфронси лозимиро пайдо кунед.

#### Example 1:
    Input: intervals = [(0,30),(5,10),(15,20)]
    Output: 2
    Explanation:
    We need two meeting rooms / Нам нужны два конференц-зала
    room1: (0,30)
    room2: (5,10),(15,20)

#### Example 2:
    Input: intervals = [(2,7)]
    Output: 1
    Explanation:
    Only need one meeting room / Нужен только один конференц-зал


### 8 Question
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well. You must not use any built-in exponent function or operator. For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.

Учитывая неотрицательное целое число x, верните квадратный корень из x, округленный до ближайшего целого числа. Возвращаемое целое число также должно быть неотрицательным. Вы не должны использовать какие-либо встроенные функции или операторы экспоненты. Например, не используйте pow(x, 0.5) в C++ или x** 0.5 в Python.
 

#### Example 1:
    Input: x = 4
    Output: 2
    Explanation: The square root of 4 is 2, so we return 2. / Квадратный корень из 4 равен 2, поэтому мы возвращаем 2.

#### Example 2:
    Input: x = 8
    Output: 2
    Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned. / Квадратный корень из 8 равен 2,82842..., и поскольку мы округляем его до ближайшего целого числа, возвращается 2.

### 9 Question
You are given an array prices where prices[i] is the price of a given stock on the ith day. You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock. Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0. 

Вам дан массив цен, где цены[i] — цена данной акции на i-й день. Вы хотите максимизировать свою прибыль, выбрав один день для покупки одной акции и выбрав другой день в будущем для продажи этой акции. Верните максимальную прибыль, которую вы можете получить от этой сделки. Если вы не можете получить прибыль, верните 0.

Ба шумо массиви нархҳо дода мешавад, ки дар он нархҳо[i] нархи саҳмияҳои додашуда дар рӯзи i мебошанд. Шумо мехоҳед, ки фоидаи худро тавассути интихоби як рӯз барои харидани як саҳмия ва интихоби рӯзи дигар дар оянда барои фурӯши ин саҳмия ба ҳадди аксар расонед. Фоидаи ҳадди аксарро, ки шумо аз ин транзаксия ба даст оварда метавонед, баргардонед. Агар шумо ягон фоида ба даст наоваред, 0-ро баргардонед.

#### Example 1:
    Input: prices = [7,1,5,3,6,4]
    Output: 5
    Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell. / Покупайте в день 2 (цена = 1) и продавайте в день 5 (цена = 6), прибыль = 6-1 = 5. Обратите внимание, что покупка во второй день и продажа в первый день не разрешены, поскольку вы должны купить, прежде чем продавать.

#### Example 2:
    Input: prices = [7,6,4,3,1]
    Output: 0
    Explanation: In this case, no transactions are done and the max profit = 0. / В этом случае транзакции не выполняются, а максимальная прибыль = 0.


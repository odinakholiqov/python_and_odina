# EXAM FOR WEEK 2
## RULES:
> No interner, no help to each other!
> Make one file and place all your work there (e.g. odina_kholiqov.py)
> Send the file at 
> You have 2 hours only

### 1 Question
Write a program to raise a natural number to a power of a given number recursively / Напишите программу, рекурсивно возводящую натуральное число в степень заданного числа
```
Input: power(2, 3)
Output: 8
```

### 2 Question
Write a program to generate and print a dictionary that contains a number (between 1 and n) in the form (x, x* / Напишите программу для создания и печати словаря, содержащего число (от 1 до n) в форме (x, x*x)

```
Input: func_name(n=5)
Output: {1: 1, 2: 4, 3: 9, 4: 16, 5: 25}
```

### 3 Question
Write a program that merges two dictionaries into one / Напишите программу, объединяющую два словаря в один
```
Input: data_1, data_2 = {1: 1, 2: 4, 3: 9}, {4: 16, 5: 25, 6: 36}
Output: {1: 1, 2: 4, 3: 9, 4: 16, 5: 25, 6: 36}
```

### 4 Question
Write a Python program to drop empty items from a dictionary / Напишите программу на Python для удаления пустых элементов из словаря.
```
Input: {'c1': 'Red', 'c2': 'Green', 'c3': None}
Output: {'c1': 'Red', 'c2': 'Green'}
```

### 5 Question
Write a program to transform a dictionary into a list of tuples / Напишите программу преобразования словаря в список кортежей.
```
Input: {'Red': 1, 'Green': 3, 'White': 5, 'Black': 2, 'Pink': 4}
Output: [('Red', 1), ('Green', 3), ('White', 5), ('Black', 2), ('Pink', 4)]
```

### 6 Question
Write a program to filter a dictionary based on values / Напишите программу для фильтрации словаря по значениям.
```
Input: {'Apple': 10, 'Orange': 3, 'Banana': 14, 'Watermelon': 21, 'Lemon': 8}
Output: {'Orange': 3,  'Lemon': 8,  'Apple': 10, ' 'Banana': 14, 'Watermelon': 21}
```
### 7 Question
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target / Учитывая массив целых чисел nums и целочисленную цель, верните индексы двух чисел так, чтобы их сумма составляла цель.
```
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1] / Поскольку nums[0] + nums[1] == 9, мы возвращаем [0, 1].
```

### 8 Question
Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), determine if a person could attend all meetings / Учитывая массив временных интервалов встреч, состоящий из времени начала и окончания [[s1,e1],[s2,e2],...] (si < ei), определите, может ли человек присутствовать на всех встречах.

Note: (0,8),(8,10) is not a conflict at 8 / Примечание: (0,8),(8,10) не является конфликтом в 8.

Example1
```
Input: intervals = [(0,30),(5,10),(15,20)]
Output: false
Explanation: (0,30), (5,10) and (0,30),(15,20) will conflict
```

Example2
```
Input: intervals = [(5,8),(9,15)]
Output: true
Explanation: Two times will not conflict
```
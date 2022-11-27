# Итоговая проверочная работа.
## *Задача*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## *Алгоритм программы*
1. Объявляем два массива. Изначальный и второй равный длинны первого.
2. Создаём метод с циклом *for* соразмерный длинне массива, в котором задаём переменную *count = 0*, которая считает количество строк, длина которых меньше либо равна 3 символа.
3. Внутри цикла *for* создаем цикл, для того чтобы проверить каждое значение из массива на соответствие условию: длина строки меньше или равна трем. Если строка соответствует условию, добавляем её в *count* элемент второго массива. 
5. Проходим по циклу пока не достигнем конца изначального массива.
6. Выводим новый массив с результатом в консоль.

## *Примеры массивов и результаты выводов*
>["hello", "2", "world", ":-)"] -> ["2", ":-)"]

>["1234", "1567", "-2", "computer science"] -> ["-2"]

>["Russia", "Denmark", "Kazan"] -> []
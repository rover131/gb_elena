# Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строкб длина который
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиятуры, либо задать на старте
выполнения алгоритма. 

1. Сначало вводим данные. Елси в C#, число элементов в массиве можно не вводить, но так-как это
текстовое решенее задачи, это вводим тоже. Назавем эту длинну N.

2. Создаем массив из N строк. Больше не будет, так-как в изначальном массиве только N строк,
и крайний случай когда длинны всех строк меньше либо равны 3 символа.

3. Объевляем переменныю j, которая будет являться счетчиков для второго, не исходного, массива. Задаем изначальное значения 0.

4. Перебираем циклом for элементы исходного массива. Мы это можем сделать потому-что мы знаем количество элементов в массива, N.

5. Проверяем длинну строки: если она меньше либо равна трем символам, записываем в ячейку второго массива под индексом j, а так-же инкрементируем этот индекс. В противном случае ничего не делаем и цикл переходит на следующую итерацию.

6. Когда цикл закончил свою работу, выводим финальный массив. Это тоже можно сделать через цикл for.
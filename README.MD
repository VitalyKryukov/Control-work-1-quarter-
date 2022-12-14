# Итоговый проект
##  Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. Первоначально массив можно ввести с помощью клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Решение:
**Алгоритм работы программы:**

1. Программа запускается через метод **Main**, который:

    1.1. Задает массив *stringArray* на старте выполнения алгоритма;

    1.2. Выводит массив *stringArray* на печать при помощи метода **PrintArray**;

    1.3. Из имеющегося массива *stringArray* формирует массив *resultArray*, состоящий из строк, длинна которых меньше либо равна 3-м символам. Для реализации данного функционала используется метод **GetResultArray.**

    1.4. Выводит массив *resultArray* на печать при помощи метода **PrintArray**.

**Используемые методы**

**Main** - основной метод, запускающий программу.

**PrintArray** - универсальный метод, позволяющий распечатать любой массив (метод используя цикл foreach, перебирает каждый элемент массива и выводит его на печать).
    
**GetResultArray** - метод, который:

* на вход принимает исходный массив *stringArray*; 
* через цикл for проверяет каждый эллемент массива на соответствие условию задачи *(тут и далее по тексту - длинна строки меньше либо равна 3 символа)*;
* заполняет новый массив *resultStringIndexes*, данными, соответствующими условиям задачи и запоминает количество данных элементов *resultArraySize*;
* заполняет новый массив *resultArray* размерностью *resultArraySize* данными из массива *resultStringIndexes* (таким образом получаем массив, который заполнен, только элементами, соответствующими условию задачи).

**Блок-схема алгоритма работы программы**

![Блок-схема](algorithm.png)



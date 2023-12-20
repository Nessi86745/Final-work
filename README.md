# **Итоговая контрольная работа по основному блоку**

## Условие задачи :
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

_Задача_: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Основные этапы решения задачи :

*1.* Функция вывода элементов массива на консоль.

*2.* Функция ввода чисел через запятую и создания массива строк.

*3.* Функция, которая возвращает новый массив, содержащий только строки с длиной не более 3 символов.


### 1. Функция вывода элементов массива на консоль.

Создаём функцию типа _void_, принимающую на вход одномерный массив типа _string_. В теле функции цикл _for_ со счётчиком. Цикл выполняется пока значение счётчика меньше длинны массива (_array.Length_). В теле цикла - вывод в консоль элементов массива, по индексу счётчика, который при инициации цикла равен 0. Для разделения элементов, используется дополнительная функция консольного вывода символов ",".

### 2. Функция ввода чисел через запятую и создания массива строк.

Функция типа _string_, возвращает массив значений, вводимых пользователем с клавиатуры. В теле функции :

+ Вывод в консоль информационного сообщения пользователю "Введите значения через запятую в одну строку: ". После чего пользователь вводит значения. По окончании ввода, нажимает клавишу _Enter_.

+ Создание переменной типа string, которой присвается ввод от пользователя функцией _Console.ReadLine()_ .
Строкове значение, полученное из ввода, преобразуем в массив, строковой функцией _Split()_ . Разделитель значений для функции - "," .

+ Возвращаем массив из введённых пользователем значений.

### 3. Функция, которая возвращает новый массив, содержащий только строки с длиной не более 3 символов.

Условия по которому значения помещаются в новый массив - количество символов, меньше или равное 3. Создаём функцию, возвращающую массив типа _string_. 

В теле функции:

+ Получаем из функции ***"Number"*** массив значений и присваеваем его одномерному массиву типа _string_ .

+ Создаём переменную типа _string_ без значения, для конкатенации к ней элементов по заданному условию.

+ Создаём цикл _for_. Цикл инициируется с счётчиком типа _int_, начальное значение которого - 0. Условие цикла - значения счётчика меньше длинны массива. В конце цикла счётчик увеличивается на 1. В теле цикла проверяется длина значения. Если она меньше или равна 3, значение конкатенируется к переменной и добавляется символ ",", для последующего разбиения на массив функцией _Split()_.

+ После выхода из цикла от полученной строки значений, при положительной проверки, удаляется последний символ ",".

+ Создаётся массив значений из строковой переменной с помощью функции _Split()_. Разделитель - символ ",".

+ Массив возвращается из функции и передаётся в функцию _"PrintArray"_ для вывода значений в консоль.
# Алгоритм блок-схемы.

## Старт программы.
1. Задаем массив array
2. Объявляем переменную длины
3. Объявляем переменную temp для промежуточного хранения слова
4. Создаем второй массив, в который будем "складывать" подходящие слова
5. Объявляем переменную - счетчик.

## Работа программы.
1. Проверяем что счетчик меньше длины массива, если да, то продолжаем работу программы. Если нет, то завершаем ее.
2. Записываем в temp то, что хранится под текущим индексом и проверяем что длина слова равна переменной длины, если да, то переходим на следующий шаг. Если нет, то увеличиваем переменную index на 1 и продолжаем выполнение.
3. Записываем во второй массив подходящее по условиям слово и увеличиваем счетчик на 1
4. Когда переменная index будет равна длине массива, программа завершится и выведет результат работы (второй массив с подходящими по условию словами).

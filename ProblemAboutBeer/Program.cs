﻿// 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка
// До каждого бара идти 15-20 минут, каждый пьет пинту за 15 минут
// У первого друга лимит выпитого 1.1 литра
// у второго 1.5
// у третьего 2.2 литра
// у 4 - 3.3 литра
// Это их максимум
// Необходимо выяснить, до скольки баров смогут дойти каждый из друзей (Пройденное расстояние (в барах)), пока не упадет.
// И сколько всего времени будет потрачено на выпивку

Console.WriteLine("В моём решении, друзья встретились в пабе и поиск своего \"счастья\" начали от туда\n");
double pinta = 0.473176;
string[] nameFriends = { "Первый друг", "Второй друг", "Третий друг", "Четвёртый друг" };
double[] drinkLimit = { 1.1, 1.5, 2.2, 3.3 };
int size = drinkLimit.Length;
int[] passedBars = new int[size];
int[] maxTime = { -20, -20, -20, -20 };

for (int i = 0; i < size; i++)
{
    while (drinkLimit[i] > 0)
    {
        drinkLimit[i] -= pinta;
        passedBars[i]++;
        maxTime[i] += 20;
    }
    Console.WriteLine($"{nameFriends[i]} найдёт своё \"счастье\" в {passedBars[i]} пабе. И на это у него уйдёт от {maxTime[i] / 2} до {maxTime[i]} минут");
}
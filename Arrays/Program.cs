﻿// string fruit = {"apples" , "bananas" , "oragnges" };

string[] fruit = new string[3]; //3 näitab sõnede arvu

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are {fruitArrayLength} in your array.");

for (int i = 0; i < fruitArrayLength; i++)
{fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); } //esimeste tähtede suuremaks tegemine kogu fruit nimekirjal

foreach (string element in fruit)           // fruit elementide kuvamine
{ Console.WriteLine(element); }
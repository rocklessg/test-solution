﻿// See https://aka.ms/new-console-template for more information
using AbdulhafizTestSolution;

Console.WriteLine("Hello, World!");

var testCase1 = TestAnswer.RobberyAlertSum([1, 2, 3, 1]);
Console.WriteLine(testCase1);
var testCase2 = TestAnswer.RobberyAlertSum([2, 7, 9, 3, 1]);
Console.WriteLine(testCase2);

var testCase3 = TestAnswer.RobberyAlertSum([1, 2, 3, 1, 6]);
Console.WriteLine(testCase3);
var testCase4 = TestAnswer.RobberyAlertSum([2, 7, 9, 3, 1, 2, 3]);
Console.WriteLine(testCase4);

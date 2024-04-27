// See https://aka.ms/new-console-template for more information
using AbdulhafizTestSolution;

// Progress of this test solution implementations can be access here: https://github.com/rocklessg/test-solution

var test1 = TestAnswer.MaximumRobberyAlertSum([1, 2, 3, 1]);
Console.WriteLine(test1);
var test2 = TestAnswer.MaximumRobberyAlertSum([2, 7, 9, 3, 1]);
Console.WriteLine(test2);

var test3 = TestAnswer.MaximumRobberyAlertSum([1, 2, 3, 1, 6]);
Console.WriteLine(test3);
var test4 = TestAnswer.MaximumRobberyAlertSum([2, 7, 9, 3, 1, 2, 3]);
Console.WriteLine(test4);

var test5 = TestAnswer.MaximumRobberyAlertSum([]);
Console.WriteLine(test5);

#region Version 2
Console.WriteLine("Version 2 result=====================Version 2 Result");
var test1v2 = TestAnswer.MaximumRobberyAlertSumV2([1, 2, 3, 1]);
Console.WriteLine(test1v2);
var test2v2 = TestAnswer.MaximumRobberyAlertSumV2([2, 7, 9, 3, 1]);
Console.WriteLine(test2v2);

var test3v2 = TestAnswer.MaximumRobberyAlertSumV2([1, 2, 3, 1, 6]);
Console.WriteLine(test3v2);
var test4v2 = TestAnswer.MaximumRobberyAlertSumV2([2, 7, 9, 3, 1, 2, 3]);
Console.WriteLine(test4v2);

var test5v2 = TestAnswer.MaximumRobberyAlertSumV2([]);
Console.WriteLine(test5v2);
#endregion

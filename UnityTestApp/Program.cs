using UnityTestApp.Services;




List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 21, 60, 105, 420 };

//ReplacementLevel1 replacer = new ReplacementLevel1();
//ReplacementLevel2 replacer = new ReplacementLevel2();
ReplacementLevel3 replacer = new ReplacementLevel3();
var result = replacer.GetReplacements(numbers);

Console.WriteLine("Out: " + string.Join(", ", result));




using System;
using System.Collections.Generic;

namespace Learning.Cheer
{

class Cheer
{

	public static void CheerMain()
	{
		int i = 1, j = 2;
		BasicSyntax(ref i, out j);
		DataStructuresAndForEachAndConvertingDataTypes();

		Console.WriteLine("{0} {1}", i, j);
	}

	static void BasicSyntax(ref int reference, out int notInitializeSoPleaseAssignItInsideThisFunction)
	{
		char aChar = "Cheer"[0];
		// CurrentCultureIgnoreCase...Or use == for comparison
		Console.Write(String.Compare("Cheer", "Cheer", StringComparison.CurrentCultureIgnoreCase) + "\n");

		string hello = string.Format("{2}:{0} !\t{1}", "Hello, C#", aChar, DateTime.Now.ToString("hh:mm,dd MMM yyyy "));
		Console.WriteLine(hello);

		string verbatimPath = @"/home/windows/...";
		string bazString = @"next!
Line! "" You can see how I escape""";
		
		// Immutable number, calculated at compile time
		const int Her = 7;
		notInitializeSoPleaseAssignItInsideThisFunction = -1;
	}

	static void DataStructuresAndForEachAndConvertingDataTypes(params string[] allOtherParams)
	{
		// Array - zero indexed
		int[] array = new int[10];
		int[] orArray = {1, 2};
		
		// Lists
		List<int> intList = new List<int>();
		List<string> stringList = new List<string> {"1", "2"};
		stringList.Add("3");

		// Stack, Queue, Dictionary, Hashset, Read-only Collections, Tuple

		foreach(char character in "Hello C#".ToCharArray()) { 
			int tryInt;
			if (int.TryParse(character.ToString(), out tryInt))
				Console.WriteLine(tryInt + ": " + tryInt.ToString());
		}
	}
}

}

using System;

class GFG {
	static int binarySearch(int[] array, int left,
							int right, int search_value)
	{
		if (right >= left) {
			int mid = left + (right - left) / 2;

			if (array[mid] == search_value)
				return mid;

			if (array[mid] > search_value)
				return binarySearch(array, left, mid - 1, search_value);

			return binarySearch(array, mid + 1, right, search_value);
		}

		return -1;
	}

	public static void Main()
	{

		int[] array = { 2, 3, 4, 10, 40 };
		int n = array.Length;
		int search_value = 10;

		int result = binarySearch(array, 0, n - 1, search_value);

		if (result == -1)
			Console.WriteLine("Element not found");
		else
			Console.WriteLine("Element found at index "
							+ result);
	}
}

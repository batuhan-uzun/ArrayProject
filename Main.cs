int[] numbers = new int[10]; // Created array of 10 integers
for (int i = 0; i < 10; i++)
{
    numbers[i] = i;
}

foreach (int i in numbers) // 10 numbers printed on screen
{
    Console.WriteLine(i);
}

Array.Resize(ref numbers, numbers.Length + 1); // Array was resized to allow adding the 11th number
Console.WriteLine("Lütfen bir sayı giriniz: ");
numbers[numbers.Length - 1] = Convert.ToInt32(Console.ReadLine()); // The number entered by the user is written to the 11th position of the array

Array.Sort(numbers); // Array is sorted in ascending order
Array.Reverse(numbers); // The array sorted in ascending order is reversed to be sorted in descending order

foreach (int i in numbers) // New array with 11 numbers is printed to the screen
{
    Console.WriteLine(i);
}


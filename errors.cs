// По-долу ще откриеш 20 примера на C# програмни фрагменти, всеки от които съдържа логическа или синтактична грешка, свързана с масиви, цикли, изчисления или структури на управление (включително for, foreach, while, do-while, if, методи и др.).

1.

int[] values = { 4, 8, 15, 16, 23, 42 };
int sum = 0;
for (int i = 0; i <= values.Length; i++) {
    sum += values[i];
}
Console.WriteLine("Sum: " + sum);

2.

int[] data = { 10, 20, 30 };
int max = data[0];
foreach (int i in data) {
    if (i > max);
        max = i;
}
Console.WriteLine("Max: " + max);

3.

int[] arr = { 1, 2, 3, 4 };
int product = 1;
int index = 0;
while (index <= arr.Length) {
    product *= arr[index];
    index++;
}
Console.WriteLine("Product: " + product);

4.

int[] nums = { 7, 14, 21 };
double avg = 0;
foreach (int n in nums) {
    avg += n;
}
avg = avg / 3.0;
Console.WriteLine("Average: " + avg);

5.

int[] list = { 2, 4, 6 };
int min = int.MaxValue;
for (int i = 0; i < list.Length; i++) {
    if (list[i] < min)
        min = list[i];
    else
        min = list[i]; // <- ?
}
Console.WriteLine("Min: " + min);

6.

int[] a = { 5, 10, 15 };
int result = 0;
for (int i = 0; i < a.Length; i++) {
    result = result + a[i];
}
double avg = result / a.Length;
Console.WriteLine("Average: {0:F2}", avg);

7.

int[] scores = { 80, 90, 100 };
int total = 0;
int i = 0;
do {
    total += scores[i];
    i++;
} while (i < scores.Length);
Console.WriteLine("Total: " + total);

8.

int[] nums = { 3, 6, 9 };
for (int i = 0; i < nums.Length; i++) {
    nums[i] = nums[i] * 2;
}
Console.WriteLine("Updated: " + nums);

9.

int[] arr = { 2, 4, 6, 8 };
int i = 0;
while (i < arr.Length) {
    Console.WriteLine(arr[i]);
    i++;
}
Console.WriteLine("Done: i = " + i);

10.

int[] data = { 1, 2, 3 };
int total = 0;
for (int i = 1; i < data.Length; i++) {
    total += data[i];
}
Console.WriteLine("Sum: " + total);

11.

int[] arr = { 1, 2, 3, 4 };
int index = 0;
while (index < arr.Length) {
    if (arr[index] % 2 == 0)
        break;
    index++;
}
Console.WriteLine("First even: " + arr[index]);

12.

int[] numbers = { 10, 20, 30 };
foreach (var n in numbers) {
    n = n * 2;
}
Console.WriteLine("First: " + numbers[0]);

13.

int[] values = new int[5];
for (int i = 1; i <= values.Length; i++) {
    values[i] = i * 10;
}

14.

int[] arr = { 1, 2, 3 };
int sum = 0;
foreach (int i in arr) {
    sum += i;
}
double avg = (int)sum / arr.Length;
Console.WriteLine("Average: " + avg);

15.

int[] a = { -1, -2, -3 };
int max = 0;
foreach (int x in a) {
    if (x > max) max = x;
}
Console.WriteLine("Max: " + max);

16.

int[] data = { 2, 4, 6 };
int index = 0;
while (true) {
    Console.WriteLine(data[index]);
    index++;
}

17.

int[] array = { 5, 10, 15 };
int total = 0;
for (int i = 0; i <= array.Length; i++) {
    total += array[i];
}
Console.WriteLine("Total: " + total);

18.

int[] x = { 2, 4, 6 };
int sum = 0;
foreach (int val in x) {
    sum = sum + val;
}
double avg = sum / x.Length;
Console.WriteLine("Avg: " + avg.ToString("F2"));

19.

int[] values = { 2, 3, 4 };
for (int i = 0; i < values.Length; i++) {
    Console.WriteLine("Value: " + values[i + 1]);
}

20.

int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
// arr[2] is missing
int sum = 0;
for (int i = 0; i < arr.Length; i++) {
    sum += arr[i];
}
Console.WriteLine("Sum: " + sum);

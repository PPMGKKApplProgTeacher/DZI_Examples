Дадени са програмни фрагменти. Какъв вид алгоритъм е реализиран във всеки пример?

1

int[] arr = { 4, 2, 7, 1 };
for (int i = 0; i < arr.Length - 1; i++)
    for (int j = 0; j < arr.Length - i - 1; j++)
        if (arr[j] > arr[j + 1])
            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
Console.WriteLine(string.Join(", ", arr));

2

int[] arr = { 3, 1, 4, 5, 2 };
for (int i = 1; i < arr.Length; i++) {
    int key = arr[i];
    int j = i - 1;
    while (j >= 0 && arr[j] > key) {
        arr[j + 1] = arr[j];
        j--;
    }
    arr[j + 1] = key;
}
Console.WriteLine(string.Join(", ", arr));

3

int[] arr = { 1, 4, 5, 7, 9, 12, 18 };
int left = 0, right = arr.Length - 1, target = 7;
while (left <= right) {
    int mid = (left + right) / 2;
    if (arr[mid] == target) {
        Console.WriteLine(mid);
        break;
    }
    else if (arr[mid] < target) left = mid + 1;
    else right = mid - 1;
}

4

int[] arr = { 10, 20, 30, 40, 50 };
int target = 30;
int Search(int[] a, int left, int right) {
    if (left > right) return -1;
    int mid = (left + right) / 2;
    if (a[mid] == target) return mid;
    else if (a[mid] > target) return Search(a, left, mid - 1);
    else return Search(a, mid + 1, right);
}
Console.WriteLine(Search(arr, 0, arr.Length - 1));

5

int[] coins = { 1, 5, 10, 25 };
int amount = 37, count = 0;
Array.Sort(coins);
for (int i = coins.Length - 1; i >= 0; i--) {
    while (amount >= coins[i]) {
        amount -= coins[i];
        count++;
    }
}
Console.WriteLine(count);

6

int F(int n) {
    if (n == 0) return 0;
    if (n == 1) return 1;
    return F(n - 1) + F(n - 2);
}
Console.WriteLine(F(6));

7

int Factorial(int n) {
    if (n == 0) return 1;
    return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));

8

int[,] dp = new int[6, 6];
for (int i = 0; i < 6; i++) {
    dp[i, 0] = 1;
    dp[0, i] = 1;
}
for (int i = 1; i < 6; i++)
    for (int j = 1; j < 6; j++)
        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
Console.WriteLine(dp[5, 5]);

9

bool CanSum(int[] arr, int target) {
    if (target == 0) return true;
    if (target < 0) return false;
    foreach (int num in arr)
        if (CanSum(arr, target - num)) return true;
    return false;
}
Console.WriteLine(CanSum(new int[] { 3, 5, 7 }, 10));

10

void Permute(string prefix, string remaining) {
    if (remaining.Length == 0)
        Console.WriteLine(prefix);
    for (int i = 0; i < remaining.Length; i++)
        Permute(prefix + remaining[i], remaining.Remove(i, 1));
}
Permute("", "abc");

11

void Solve(int[] arr, int index) {
    if (index == arr.Length)
        Console.WriteLine(string.Join(", ", arr));
    for (int i = index; i < arr.Length; i++) {
        (arr[index], arr[i]) = (arr[i], arr[index]);
        Solve(arr, index + 1);
        (arr[index], arr[i]) = (arr[i], arr[index]);
    }
}
Solve(new int[] { 1, 2, 3 }, 0);

12

int ChangeWays(int[] coins, int n, int amount) {
    if (amount == 0) return 1;
    if (amount < 0 || n <= 0) return 0;
    return ChangeWays(coins, n - 1, amount) +
           ChangeWays(coins, n, amount - coins[n - 1]);
}
Console.WriteLine(ChangeWays(new int[] { 1, 2, 5 }, 3, 5));

13

int[,] grid = {
    { 1, 3, 1 },
    { 1, 5, 1 },
    { 4, 2, 1 }
};
for (int i = 1; i < 3; i++) {
    grid[i,0] += grid[i - 1,0];
    grid[0,i] += grid[0,i - 1];
}
for (int i = 1; i < 3; i++)
    for (int j = 1; j < 3; j++)
        grid[i,j] += Math.Min(grid[i - 1,j], grid[i,j - 1]);
Console.WriteLine(grid[2,2]);

14

int[,] dp = new int[6, 6];
for (int i = 1; i <= 5; i++)
    for (int j = 1; j <= 5; j++)
        dp[i,j] = dp[i - 1,j] + dp[i,j - 1] + 1;
Console.WriteLine(dp[5,5]);

15

bool IsSafe(char[,] board, int row, int col) {
    for (int i = 0; i < row; i++)
        if (board[i,col] == 'Q') return false;
    for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
        if (board[i,j] == 'Q') return false;
    for (int i = row - 1, j = col + 1; i >= 0 && j < board.GetLength(0); i--, j++)
        if (board[i,j] == 'Q') return false;
    return true;
}
void Solve(char[,] board, int row) {
    if (row == board.GetLength(0)) {
        for (int i = 0; i < board.GetLength(0); i++)
            Console.WriteLine(new string(Enumerable.Range(0, board.GetLength(1)).Select(j => board[i,j]).ToArray()));
        Console.WriteLine();
        return;
    }
    for (int col = 0; col < board.GetLength(1); col++) {
        if (IsSafe(board, row, col)) {
            board[row,col] = 'Q';
            Solve(board, row + 1);
            board[row,col] = '.';
        }
    }
}
char[,] chess = new char[4,4];
for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
        chess[i,j] = '.';
Solve(chess, 0);

16

int[] values = { 1, 2, 3, 4 };
int sum = 5;
bool ExistsSubset(int[] arr, int i, int total) {
    if (total == 0) return true;
    if (i == 0) return arr[0] == total;
    if (arr[i] > total) return ExistsSubset(arr, i - 1, total);
    return ExistsSubset(arr, i - 1, total) || ExistsSubset(arr, i - 1, total - arr[i]);
}
Console.WriteLine(ExistsSubset(values, values.Length - 1, sum));

17

int CountWays(int n) {
    if (n < 0) return 0;
    if (n == 0) return 1;
    return CountWays(n - 1) + CountWays(n - 2) + CountWays(n - 3);
}
Console.WriteLine(CountWays(5));

18

int LongestCommonSubsequence(string a, string b, int i, int j) {
    if (i == 0 || j == 0) return 0;
    if (a[i - 1] == b[j - 1])
        return 1 + LongestCommonSubsequence(a, b, i - 1, j - 1);
    else
        return Math.Max(LongestCommonSubsequence(a, b, i - 1, j), LongestCommonSubsequence(a, b, i, j - 1));
}
Console.WriteLine(LongestCommonSubsequence("abcde", "ace", 5, 3));

19

int[] prices = { 7, 1, 5, 3, 6, 4 };
int minPrice = int.MaxValue;
int maxProfit = 0;
foreach (var p in prices) {
    if (p < minPrice) minPrice = p;
    else if (p - minPrice > maxProfit) maxProfit = p - minPrice;
}
Console.WriteLine(maxProfit);

20

void PrintBinary(int n) {
    if (n == 0) return;
    PrintBinary(n / 2);
    Console.Write(n % 2);
}
PrintBinary(13);

21

int[,] memo = new int[100,100];
int Ways(int m, int n) {
    if (m == 0 || n == 0) return 1;
    if (memo[m,n] != 0) return memo[m,n];
    return memo[m,n] = Ways(m - 1, n) + Ways(m, n - 1);
}
Console.WriteLine(Ways(3, 3));

22

int Climb(int n) {
    if (n <= 2) return n;
    int first = 1, second = 2, res = 0;
    for (int i = 3; i <= n; i++) {
        res = first + second;
        first = second;
        second = res;
    }
    return res;
}
Console.WriteLine(Climb(5));

23

void Subsets(List<int> list, List<int> current, int index) {
    if (index == list.Count) {
        Console.WriteLine(string.Join(",", current));
        return;
    }
    Subsets(list, new List<int>(current), index + 1);
    current.Add(list[index]);
    Subsets(list, current, index + 1);
}
Subsets(new List<int> { 1, 2, 3 }, new List<int>(), 0);

24

int Count(int n) {
    if (n == 0) return 0;
    return 1 + Count(n / 10);
}
Console.WriteLine(Count(123456));

25

int MaxSum(int[] nums) {
    int include = nums[0];
    int exclude = 0;
    for (int i = 1; i < nums.Length; i++) {
        int temp = include;
        include = Math.Max(include, exclude + nums[i]);
        exclude = temp;
    }
    return include;
}
Console.WriteLine(MaxSum(new int[] { 2, 7, 9, 3, 1 }));

26

void Combine(List<int> list, List<int> current, int k, int start) {
    if (current.Count == k) {
        Console.WriteLine(string.Join(",", current));
        return;
    }
    for (int i = start; i < list.Count; i++) {
        current.Add(list[i]);
        Combine(list, current, k, i + 1);
        current.RemoveAt(current.Count - 1);
    }
}
Combine(new List<int> { 1, 2, 3, 4 }, new List<int>(), 2, 0);

27

string Reverse(string s) {
    if (s.Length == 0) return "";
    return Reverse(s.Substring(1)) + s[0];
}
Console.WriteLine(Reverse("recursion"));

28

int Pow(int a, int b) {
    if (b == 0) return 1;
    int half = Pow(a, b / 2);
    return b % 2 == 0 ? half * half : a * half * half;
}
Console.WriteLine(Pow(2, 10));

29

int SumDigits(int n) {
    if (n == 0) return 0;
    return n % 10 + SumDigits(n / 10);
}
Console.WriteLine(SumDigits(12345));

30

int[,] dp = new int[10,10];
int Knapsack(int[] weights, int[] values, int w, int n) {
    if (n == 0 || w == 0) return 0;
    if (weights[n - 1] > w) return Knapsack(weights, values, w, n - 1);
    return Math.Max(
        values[n - 1] + Knapsack(weights, values, w - weights[n - 1], n - 1),
        Knapsack(weights, values, w, n - 1)
    );
}
Console.WriteLine(Knapsack(new int[] { 1, 3, 4, 5 }, new int[] { 1, 4, 5, 7 }, 7, 4));

31

int CountPaths(int n) {
    if (n == 0 || n == 1) return 1;
    return CountPaths(n - 1) + CountPaths(n - 2);
}
Console.WriteLine(CountPaths(4));

32

void Generate(string str, int open, int close, int max) {
    if (str.Length == max * 2) {
        Console.WriteLine(str);
        return;
    }
    if (open < max) Generate(str + "(", open + 1, close, max);
    if (close < open) Generate(str + ")", open, close + 1, max);
}
Generate("", 0, 0, 3);

33

int UniquePaths(int m, int n) {
    int[,] dp = new int[m,n];
    for (int i = 0; i < m; i++) dp[i,0] = 1;
    for (int j = 0; j < n; j++) dp[0,j] = 1;
    for (int i = 1; i < m; i++)
        for (int j = 1; j < n; j++)
            dp[i,j] = dp[i - 1,j] + dp[i,j - 1];
    return dp[m - 1,n - 1];
}
Console.WriteLine(UniquePaths(3, 3));

34

bool Palindrome(string s, int i, int j) {
    if (i >= j) return true;
    if (s[i] != s[j]) return false;
    return Palindrome(s, i + 1, j - 1);
}
Console.WriteLine(Palindrome("level", 0, 4));

35

int GCD(int a, int b) {
    if (b == 0) return a;
    return GCD(b, a % b);
}
Console.WriteLine(GCD(48, 18));

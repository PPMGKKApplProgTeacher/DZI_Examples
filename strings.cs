// Това са въпроси от типа „Какво ще се изведе?“, „Какво ще бъде съдържанието на променливата?“ и т.н.
// Не включвам отговори или обяснения, за да могат да се използват за тестове или упражнения.
1.

string s = "Hello World";
string part = s.Substring(6, 5);
Console.WriteLine(part);

2.

string input = "  C# Language  ";
string trimmed = input.Trim();
Console.WriteLine(trimmed.Length);

3.

string s = "Programming";
int index = s.IndexOf("g");
Console.WriteLine(index);

4.

string s = "abcabcabc";
int pos = s.LastIndexOf("a");
Console.WriteLine(pos);

5.

string text = "Visual Studio";
string result = text.Replace("Studio", "Code");
Console.WriteLine(result);

6.

string str = "Testing123";
char ch = str[4];
Console.WriteLine(ch);

7.

string sentence = "Data Structures and Algorithms";
bool contains = sentence.Contains("Algorithms");
Console.WriteLine(contains);

8.

string code = "ABCD";
string lower = code.ToLower();
Console.WriteLine(lower);

9.

string lang = "CSharp";
string sub = lang.Substring(1);
Console.WriteLine(sub);

10.

string msg = "hello";
string upper = msg.ToUpper();
Console.WriteLine(upper);

11.

string path = "folder/file.txt";
int slash = path.IndexOf("/");
string filename = path.Substring(slash + 1);
Console.WriteLine(filename);

12.

string s1 = "apple";
string s2 = "Apple";
bool equal = s1.Equals(s2);
Console.WriteLine(equal);

13.

string data = "123456789";
string removed = data.Remove(3, 2);
Console.WriteLine(removed);

14.

string input = "object-oriented";
string inserted = input.Insert(7, "/");
Console.WriteLine(inserted);

15.

string name = "Michael";
bool starts = name.StartsWith("Mi");
bool ends = name.EndsWith("el");
Console.WriteLine(starts + " " + ends);

16.

string str = "repeat repeat repeat";
int count = str.Split("repeat").Length - 1;
Console.WriteLine(count);

17.

string quote = "To be or not to be";
int first = quote.IndexOf("be");
int second = quote.IndexOf("be", first + 1);
Console.WriteLine(first + " " + second);

18.

string x = "aaaabbbb";
x = x.Replace("a", "b");
Console.WriteLine(x);

19.

string word = "BackEnd";
char first = word[0];
char last = word[word.Length - 1];
Console.WriteLine(first + " " + last);

20.

string text = "123ABC456";
int index = text.IndexOfAny(new char[] { 'A', 'B', 'C' });
Console.WriteLine(index);

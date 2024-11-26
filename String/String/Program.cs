using System;

class StringComparisonDemo
{
    static void Main()
    {
        string str1 = "Тема пятая, строки";
        string str2 = "Тема пятая, строки";
        string str3 = "Тема пятая, строки";
        string substring = "строки";

        // 1. Compare()
        int compareResult = string.Compare(str1, str2); // Сравнение с учетом регистра
        Console.WriteLine($"Compare(str1, str2): {compareResult}");

        // 2. Equals()
        bool equalsResult = str1.Equals(str3); // Сравнение на равенство
        Console.WriteLine($"Equals(str1, str3): {equalsResult}");

        // 3. CompareOrdinal()
        int compareOrdinalResult = string.CompareOrdinal(str1, str2); // Сравнение символов по их порядку в Unicode
        Console.WriteLine($"CompareOrdinal(str1, str2): {compareOrdinalResult}");

        // 4. IndexOf()
        int indexOfSubstring = str1.IndexOf(substring); // Поиск индекса подстроки
        Console.WriteLine($"IndexOf(substring): {indexOfSubstring}");

        // 5. Contains()
        bool containsResult = str1.Contains(substring); // Проверка на наличие подстроки
        Console.WriteLine($"Contains(substring): {containsResult}");

        // 6. Оператор ==
        bool isEqual = str1 == str3; // Проверка равенства строк
        Console.WriteLine($"str1 == str3: {isEqual}");

        // 7. Оператор !=
        bool isNotEqual = str1 != str2; // Проверка неравенства строк
        Console.WriteLine($"str1 != str2: {isNotEqual}");
    }
}

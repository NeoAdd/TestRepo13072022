// Словарь

string s = "ergrgaergwergerg";
var diect = s.GroupBy(e=>e);
foreach (var kvp in diect)
{
    Console.WriteLine($"{kvp.Key} {kvp.Count()}");
}

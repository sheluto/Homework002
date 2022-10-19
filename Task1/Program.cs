// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine()??"0");
if (number >= 6)
{
    Console.WriteLine("Ура! Сегодня выходной!");

}
else
{
    Console.WriteLine("Сегодня рабочий день");
}
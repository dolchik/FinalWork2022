string[] ArrayThreeItems(string[] array) //Метод проверяет элементы входного массива на длину и из подходящих сздает новый массив
{
    int arraySizeNew = 0;
    string[] arrayNew = new string[arraySizeNew];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length == 3)
        {
            arraySizeNew++;
            Array.Resize(ref arrayNew, arraySizeNew);
            arrayNew[arraySizeNew - 1] = array[i];
        }
    }
    return arrayNew;
}

Console.Clear();
string[] array = { "awa1", "tt2", "hgti", "t94", "asdf", "nbngjf" };
Console.WriteLine("[" + string.Join(", ", array) + "]");
string[] arrayNew = ArrayThreeItems(array);
Console.WriteLine("[" + string.Join(", ", arrayNew) + "]");
// See https://aka.ms/new-console-template for more information
int[] array = new int [123];
int sum = 0;
for (int count = 0; count < 123; count++) {
    array[count] = new Random().Next(1, 1000);
}
for (int count = 0; count < 123; count ++) {
    if (array[count] > 9 && array[count] < 100) {
        sum +=1;
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Количество элементов массива лежащих в отрезке от 10 до 99  = {sum}");
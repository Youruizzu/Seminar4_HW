Console.Clear();

void ShowArray(int size){
    int[] array = new int[size];
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++){
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]}, ");
    }
    array[array.Length - 1] = new Random().Next(1, 10);
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

ShowArray(20);
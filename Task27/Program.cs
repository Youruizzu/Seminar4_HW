Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InNumSum(int number){
    int result = 0;
    while (number > 0){
        int num = number;
        result += num%10;
        number /= 10;
    }
    return result;
}

Console.WriteLine(InNumSum(Prompt("Введите число: ")));
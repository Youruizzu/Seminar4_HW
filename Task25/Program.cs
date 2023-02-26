Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Power(double number, double power){
    double num = number;
    for(int i = 1; i < power; i++){
        number *= num;
    }
    return number;
}

Console.WriteLine(Power(Prompt("Введите число: "), Prompt("Введите степень: ")));
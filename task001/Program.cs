int EnterMes(string Message){
    Console.Write(Message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int count = 0;
int countNamber = EnterMes("Введите колличество введённых чисел: ");
for(int i = 1; i <= countNamber; i++){
    int namber = EnterMes($"Введите число {i}: ");
    if(namber > 0) count++;
}

Console.WriteLine($"Количество чисел больше нуля: {count}");
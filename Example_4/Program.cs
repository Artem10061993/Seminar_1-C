Console.WriteLine("Введите положительное число");
int x = Convert.ToInt32(Console.ReadLine());
int y = -x;
while(y<=x)
{
    Console.Write(" "+y);
    y = y+1;
    
}

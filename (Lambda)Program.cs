var input1 = Console.ReadLine();
var input2 = Console.ReadLine();

int num1 = System.Convert.ToInt32(input1);
int num2 = System.Convert.ToInt32(input2);

(num1,num2) = (num2,num1);
Console.WriteLine(num1 + ", " + num2);
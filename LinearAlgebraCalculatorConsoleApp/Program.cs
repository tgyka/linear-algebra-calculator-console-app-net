using LinearAlgebraCalculatorConsoleApp.Core;

Console.WriteLine(ConstMessages.Welcome);

try
{
    MatrixUI.UI();
}
catch(Exception e)
{
    Console.WriteLine(e.Message); 
}


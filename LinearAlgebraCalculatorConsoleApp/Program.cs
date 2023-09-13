using LinearAlgebraCalculatorConsoleApp.Core;
using LinearAlgebraCalculatorConsoleApp.Models;


Console.WriteLine("Welcome.You can do various linear algebra calculations by this app.");


try
{
    MatrixUI.UI();
}
catch(Exception e)
{
    Console.WriteLine(e.Message); 
}


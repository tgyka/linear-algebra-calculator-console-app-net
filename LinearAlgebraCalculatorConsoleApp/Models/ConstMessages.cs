using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCalculatorConsoleApp.Models
{
    public static class ConstMessages
    {
        public static string Welcome => "Welcome.You can do various linear algebra calculations by this app.";
        public static string EnterMatrixCount => "Please enter matrix row count: ";
        public static string EnterValidNumber => "Please enter valid number";
        public static string EnterRowNumbers => "Enter {0} row numbers with a comma (Ex: '3,4,5'): ";
        public static string InvalidMatrixDecleration => "Invalid matrix decleration";
        public static string EnterResultColumnNumbers => "Enter result column numbers by top down (Ex: '3,4,5'): ";
        public static string WriteNumberWithComma => "Please write {0} number with comma";
        public static string SelectCalculationType => "Please select calculation type ?";
    }
}

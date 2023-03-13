namespace RazorPagesDemo.Models
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Add() => Num1 + Num2;
        public int Subtract() => Num1 - Num2; 
        public int Multiply() => Num1 * Num2;
        public double Divide() => Num1 / Num2;

    }
}

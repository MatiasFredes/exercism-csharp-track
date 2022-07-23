using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operation == null) throw new ArgumentNullException();
        if (operation == string.Empty) throw new ArgumentException();

        string result = string.Empty;
        switch (operation)
        {
            case "+":
                {
                    result = SimpleOperation.Addition(operand1, operand2).ToString();
                    break;
                }
            case "*":
                {
                    result = SimpleOperation.Multiplication(operand1, operand2).ToString();
                    break;
                }
            case "/":
                {
                    try
                    {
                        result = SimpleOperation.Division(operand1, operand2).ToString();
                       
                    }
                    catch(DivideByZeroException)
                    {
                        return "Division by zero is not allowed.";
                    }
                    break;
                }
            default: throw new ArgumentOutOfRangeException();
        }
        
        return $"{operand1} {operation} {operand2} = {result}";
    }
}

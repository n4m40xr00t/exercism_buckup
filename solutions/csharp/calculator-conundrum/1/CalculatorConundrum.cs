public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        long result = 0;

        switch (operation)
        {
            case "+":
                result = SimpleOperation.Addition(operand1, operand2);
                break;
            case "*":
                result = SimpleOperation.Multiplication(operand1, operand2);
                break;
            case "/":
                try
                {
                    if (operand2 != 0)
                    {
                        result = SimpleOperation.Division(operand1, operand2);
                    }
                    else
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                }
                catch (DivideByZeroException e)
                {
                    return String.Format("{0}", e.Message);
                    
                }
                break;
            case "":
                throw new ArgumentException("Operation must not be blank.");
            case null:
                throw new ArgumentNullException("Operation must not be null.");
            default:
                throw new ArgumentOutOfRangeException("Operation must be +, *, /.");
        }

        return String.Format("{0} {1} {2} = {3}", operand1, operation, operand2, result);
    }
}

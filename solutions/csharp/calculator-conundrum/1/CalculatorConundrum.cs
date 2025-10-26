public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        string res; 
        switch (operation){
            case "+":
                res = $"{operand1} + {operand2} = {operand1 + operand2}";
                break;
            case "*":
                res = $"{operand1} * {operand2} = {operand1 * operand2}";
                break;
            case "/":
                if (operand2 == 0){
                    res = "Division by zero is not allowed.";
                } else{
                    res = $"{operand1} / {operand2} = {operand1 / operand2}";
                }
                break;
            case "":
                throw new ArgumentException("Empty operation");
            case null:
                throw new ArgumentNullException("Operation must not be null");
            default:
                throw new ArgumentOutOfRangeException("Unknown operation");
        }

        return res;
    }
}

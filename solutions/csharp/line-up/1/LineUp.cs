public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix;
         if (number % 100 >= 11 && number % 100 <= 13)
        {
            suffix = "th";
        }
        else
        {
            switch (number % 10)
            {
                case 1:
                    suffix = "st";
                    break;
                case 2:
                    suffix = "nd";
                    break;
                case 3:
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
        }
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}

using Application.Enum;

namespace Application.Services
{
    public class ZodiacalService
    {
        public string WhichIsMySign(int Month, int Day)
        {
            string result = string.Empty;
            string sign = string.Empty;

            switch (Month)
            {
                case (int)ZodiacalMonths.January:
                    if (Day > 31) 
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 20)
                    {
                        sign = "Capricornio ♑";
                        result = sign;
                    } else if (Day >= 21 && Day <= 31)
                    {
                        sign = "Acuario ♒";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.February:
                    if (Day > 29)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 18)
                    {
                        sign = "Acuario ♒";
                        result = sign;
                    }
                    else if (Day >= 19 && Day <= 29)
                    {
                        sign = "Piscis ♓";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.March:
                    if (Day > 31)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 20)
                    {
                        sign = "Piscis ♓";
                        result = sign;
                    }
                    else if (Day >= 21 && Day <= 31)
                    {
                        sign = "Aries ♈";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.April:
                    if (Day > 30)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 19)
                    {
                        sign = "Aries ♈";
                        result = sign;
                    }
                    else if (Day >= 20 && Day <= 30)
                    {
                        sign = "Tauro ♉";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.May:
                    if (Day > 31)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 20)
                    {
                        sign = "Tauro ♉";
                        result = sign;
                    }
                    else if (Day >= 21 && Day <= 31)
                    {
                        sign = "Géminis ♊";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.June:
                    if (Day > 30)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 20)
                    {
                        sign = "Géminis ♊";
                        result = sign;
                    }
                    else if (Day >= 21 && Day <= 30)
                    {
                        sign = "Cáncer ♋";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.July:
                    if (Day > 31)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 22)
                    {
                        sign = "Cáncer ♋";
                        result = sign;
                    }
                    else if (Day >= 23 && Day <= 31)
                    {
                        sign = "Leo ♌";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.August:
                    if (Day > 31)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 22)
                    {
                        sign = "Leo ♌";
                        result = sign;
                    }
                    else if (Day >= 23 && Day <= 31)
                    {
                        sign = "Virgo ♍";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.September:
                    if (Day > 30)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 22)
                    {                        
                        sign = "Virgo ♍";
                        result = sign;
                    }
                    else if (Day >= 23 && Day <= 30)
                    {
                        sign = "Libra ♎";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.October:
                    if (Day > 31)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 22)
                    {
                        sign = "Libra ♎";
                        result = sign;
                    }
                    else if (Day >= 23 && Day <= 31)
                    {
                        sign = "Escorpio ♏";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.November:
                    if (Day > 30)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 21)
                    {
                        sign = "Escorpio ♏";
                        result = sign;
                    }
                    else if (Day >= 22 && Day <= 30)
                    {
                        sign = "Sagitario ♐";
                        result = sign;
                    }
                    break;

                case (int)ZodiacalMonths.December:
                    if (Day > 31)
                    {
                        result = "";
                    }
                    else if (Day >= 1 && Day <= 21)
                    {
                        sign = "Sagitario ♐";
                        result = sign;
                    }
                    else if (Day >= 22 && Day <= 31)
                    {
                        sign = "Capricornio";
                        result = sign;
                    }

                    break;
            }

            return result;
        }

    }
}

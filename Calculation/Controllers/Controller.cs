using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        [HttpPost]
        public string Result(string First, string Second, string Znak)
        {

            if (!Double.TryParse(First, out double result))
            {
                return "Неверный первый входной параметр";

            }
            else
            {
                if (!Double.TryParse(Second, out result))
                {
                    return "Неверный второй входной параметр";
                }
                else
                {
                }
                if (Znak == "Inc")
                {
                    return Convert.ToString(Convert.ToDouble(First) + Convert.ToDouble(Second));
                }
                else
                {
                    if (Znak == "Dec")
                    {
                        return Convert.ToString(Convert.ToDouble(First) - Convert.ToDouble(Second));
                    }
                    else
                    {
                        if (Znak == "Ymno")
                        {
                            return Convert.ToString(Convert.ToDouble(First) * Convert.ToDouble(Second));
                        }
                        else
                        {
                            if (Znak == "Del")
                            {
                                if (Convert.ToDouble(Second) == 0)
                                { return "Деление на нуль"; }
                                else
                                {
                                    return Convert.ToString(Convert.ToDouble(First) / Convert.ToDouble(Second));
                                }
                            }
                            else
                            {
                                return "Ошибка математического знака";
                            }
                        }
                    }
                }
            }
        }
    }
}

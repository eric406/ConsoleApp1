using ConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 天氣製造工廠模式
    /// </summary>
    public class WeatherFactory
    {
        /// <summary>
        /// 依序傳入的參數產生對應的天氣
        /// </summary>
        /// <param name="currentWeather"></param>
        /// <returns></returns>
        public WeatherEnum GenerateWeather(int currentWeather) 
        {
            return (WeatherEnum)currentWeather;
        }
   }

}

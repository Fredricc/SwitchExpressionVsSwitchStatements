using SwitchExpressionVsSwitchStatements;

namespace SwitchExpressionVsSwitchStatements
{
    enum TemperatureUnit
    {
        Celsius,
        Fahrenheit,
        Kelvin,
        Test
    }

    class Temperature
    {
        public Temperature(TemperatureUnit unit, decimal value)
        {
            Unit = unit;
            Value = value;
        }

        public TemperatureUnit Unit { get; set; }
        public decimal Value { get; set; }

        public decimal ValueInCelsius
        {
            get
            {
                return Unit switch
                {

                    TemperatureUnit.Celsius => Value,
                    TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                    TemperatureUnit.Kelvin => Value - 273.15m,
                    _ => 0
                } ;
                //switch (Unit)
                //{
                //    case TemperatureUnit.Celsius:
                //    return Value;
                //    case TemperatureUnit.Fahrenheit:
                //        return (Value - 32) * 5 / 9;
                //    case TemperatureUnit.Kelvin:
                //        return Value - 273.15m;
                //    default:
                //        return 0;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var temperature = new Temperature(TemperatureUnit.Test, 10);
            Console.WriteLine($"Temperature: {temperature.ValueInCelsius.ToString("0,0")}C");
        }
    }

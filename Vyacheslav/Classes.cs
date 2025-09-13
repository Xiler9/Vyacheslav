 namespace Vyacheslav
{
    public class Filter
    {
        public int[] numbers { get; set; }
        public bool onlyEven { get; set; }
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Value
    {
        public int[] values { get; set; }
    }

    public class Rectangle
    {
        public int heigh {  get; set; }
        public int width { get; set; }
    }

    public class Circle
    {
        public int radius { get; set; }
    }

    public class Triangle
    {
        public int foundation { get; set; }
        public int heigh { get; set; }
    }

    public class Weather
    {
        public string name;
        public List<float> values { get; set; }

        public Weather(string name)
        {
            this.name = name;
        }

        public float Count()
        {
            return values.Count;
        }
        public float Average()
        {
            return values.Average();
        }
    }

    public class AddValuesRequest
    {
        public string name { get; set; }
        public List<float> values { get; set; } = new List<float>();
    }
}

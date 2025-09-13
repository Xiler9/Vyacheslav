using Microsoft.AspNetCore.Mvc;

namespace Vyacheslav.Controllers
{
    [ApiController]
    [Route("api")]
    public class HwController
    {
        [HttpPost("lists/create")]
        public string NameList(string name)
        {
            Weathers.weathers.Add(new Weather(name));
            return $"\"message\": \"List \'{name}\' created\"";
        }

        [HttpPost("lists/add")]
        public string AddValues([FromBody] AddValuesRequest addValuesRequest)
        {
            int index = Weathers.weathers.FindIndex(x => x.name == addValuesRequest.name);
            Console.WriteLine(index);
            Weathers.weathers[index].values.AddRange(addValuesRequest.values);
            float count = Weathers.weathers[index].values.Count();
            return $"\"count\": {count}";
        }

        [HttpGet("stats")]
        public string GetStats(string name)
        {
            int index = Weathers.weathers.FindIndex(x => x.name == name);
            return $"\"name\": \"{name}\"\n" +
                   $"\"count\": \"{Weathers.weathers[index].Count()}\"\n" +
                   $"\"sum\": \"{Weathers.weathers[index].values.Sum()}\"\n" +
                   $"\"average\": \"{Weathers.weathers[index].values.Average()}\"";
        }

        [HttpGet("stats/all")]
        public string GetAllStats()
        {
            string answer = string.Empty;
            foreach (var weathers in Weathers.weathers)
            {
                answer += 
                    $"\"name\": \"{weathers.name}\"\n" +
                    $"\"count\": \"{weathers.Count()}\"\n" +
                    $"\"sum\": \"{weathers.values.Sum()}\"\n" +
                    $"\"average\": \"{weathers.values.Average()}\"\n";           
            }
            return answer ;
        }

        [HttpPost("filter")]
        public string NumbersFilter([FromBody] Filter filter)
        {
            string filtredArray = string.Empty;
            for (int i = 0; i < filter.numbers.Count(); i++)
            {
                int number = filter.numbers[i];
                if (number >= filter.min && number <= filter.max && number % 2 == 0)
                {
                    filtredArray += (number + ", ");
                }
            }
            filtredArray = filtredArray.Remove(filtredArray.Length - 2);
            return filtredArray;
        }

        [HttpPost("statistics")]
        public string ValueHandler([FromBody] Value value)
        {
            int[] values = value.values;
            int count = values.Count();
            int sum = values.Sum();
            float average = sum / count;
            int min = values.Min();
            int max = values.Max();
            return
                $"\"count\": {count}\n" +
                $"\"sum\": {sum}\n" +
                $"\"average\": {average}\n" +
                $"\"min\": {min}\n" +
                $"\"max\": {max}\n";
        }
    }
}
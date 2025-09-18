using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Models
{
    public class Request
    {
        public string Text {  get; set; }
        public string Recepient { get; set; }
        public Privilege Privilege { get; set; }
    }
}
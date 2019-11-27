using System.Linq;

namespace Queue.Models
{
    public class DoubleLinkItem<T>
    {
        public T Data { get; set; }
        public DoubleLinkItem<T> Next { get; set; }
        public DoubleLinkItem<T> Previous { get; set; }

        public DoubleLinkItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
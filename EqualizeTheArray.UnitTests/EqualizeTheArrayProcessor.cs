namespace EqualizeTheArray.UnitTests
{
    internal class EqualizeTheArrayProcessor
    {
        public EqualizeTheArrayProcessor()
        {
        }

        internal int EqualizeArray(List<int> arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            var max = dict.Values.Max();

            return arr.Count - max;
        }
    }
}
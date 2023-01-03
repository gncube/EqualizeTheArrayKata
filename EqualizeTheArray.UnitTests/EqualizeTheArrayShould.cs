namespace EqualizeTheArray.UnitTests
{
    public class EqualizeTheArrayShould
    {
        [Fact]
        public void ReturnTheMinimumNumberOfDeletionsRequired()
        {
            int[] arr = { 1, 2, 2, 3 };
            int expected = 2;
            var processor = new EqualizeTheArrayProcessor();
            int actual = processor.EqualizeArray(arr.ToList());

            Assert.Equal(expected, actual);
        }
    }
}
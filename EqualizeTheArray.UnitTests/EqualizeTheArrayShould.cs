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

        [Theory]
        [InlineData(2, new int[] { 1, 2, 2, 3 })]
        [InlineData(2, new int[] { 3, 3, 2, 1, 3 })]
        public void ReturnTheMinimumNoOfDeletionsRequired(int expected, int[] arr)
        {
            var processor = new EqualizeTheArrayProcessor();
            int actual = processor.EqualizeArray(arr.ToList());

            Assert.Equal(expected, actual);
        }
    }
}
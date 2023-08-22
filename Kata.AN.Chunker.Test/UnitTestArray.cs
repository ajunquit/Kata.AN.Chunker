namespace Kata.AN.Chunker.Test
{
    public class UnitTestArray
    {
        Chunker chunker;
        public UnitTestArray()
        {
            this.chunker = new Chunker();
        }

        [Fact(DisplayName = "Test=TestChunkArray0 with (\"abcde\", 0) should return an ArgumentException")]
        public void TestChunkArray0()
        {
            Assert.Throws<ArgumentException>(() => chunker.Chunk("abcde", 0));
        }

        [Fact(DisplayName = "Test=TestChunkArray1 with (\"abcde\", 1) should return \"abcde\"")]
        public void TestChunkArray1()
        {
            string[] expected = { "abcde" };
            string[] actual = chunker.Chunk("abcde", 1);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray2 with (\"abcde\", 2) should return \"abc\", \"de\"")]
        public void TestChunkArray2()
        {
            string[] expected = { "abc","de" };
            string[] actual = chunker.Chunk("abcde", 2);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray3 with (\"abcde\", 3) should return \"abc\", \"de\"")]
        public void TestChunkArray3()
        {
            string[] expected = { "ab","cd", "e" };
            string[] actual = chunker.Chunk("abcde", 3);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray4 with (\"abcde\", 4) should return \"ab\", \"c\", \"d\", \"e\"")]
        public void TestChunkArray4()
        {
            string[] expected = { "ab", "c", "d", "e" };
            string[] actual = chunker.Chunk("abcde", 4);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray5 with (\"abcde\", 5) should return \"a\", \"b\", \"c\", \"d\", \"e\"")]
        public void TestChunkArray5()
        {
            string[] expected = { "a", "b", "c", "d", "e" };
            string[] actual = chunker.Chunk("abcde", 5);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray6 with (\"abcde\", 6) should return \"a\", \"b\", \"c\", \"d\", \"e\"")]
        public void TestChunkArray6()
        {
            string[] expected = { "a", "b", "c", "d", "e" };
            string[] actual = chunker.Chunk("abcde", 6);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray7 with (\"abcdefghijklm\", 4) should return \"abcd\", \"efg\", \"hij\", \"klm\"")]
        public void TestChunkArray7()
        {
            string[] expected = { "abcd", "efg", "hij","klm" };
            string[] actual = chunker.Chunk("abcdefghijklm", 4);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray8 with (\"abcdefghijklm\", 4) should return \"abc\", \"def\", \"ghi\", \"jk\", \"lm\"")]
        public void TestChunkArray8()
        {
            string[] expected = { "abc", "def", "ghi", "jk", "lm" };
            string[] actual = chunker.Chunk("abcdefghijklm", 5);
            Assert.Equal(actual, expected);
        }

        [Fact(DisplayName = "Test=TestChunkArray9 with (\"abcdefghijklm\", 4) should return \"abc\", \"def\", \"ghi\", \"jk\", \"lm\"")]
        public void TestChunkArray9()
        {
            string[] expected = { };
            string[] actual = chunker.Chunk("", 5);
            Assert.Equal(actual, expected);
        }

    }
}
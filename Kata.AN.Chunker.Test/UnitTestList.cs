namespace Kata.AN.Chunker.Test
{
    public class UnitTestList
    {
        Chunker chunker;
        public UnitTestList()
        {
            this.chunker = new Chunker();
        }
        [Fact]
        public void TestChunkList_InvalidChunkSize_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => chunker.ChunkList("abcde", 0));
        }

        [Fact]
        public void TestChunkList1_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "abcde" };

            // Act
            List<string> actual = chunker.ChunkList("abcde", 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList2_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "abc", "de" };

            // Act
            List<string> actual = chunker.ChunkList("abcde", 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList3_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "ab","cd","e" };

            // Act
            List<string> actual = chunker.ChunkList("abcde", 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList4_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "ab", "c", "d", "e" };

            // Act
            List<string> actual = chunker.ChunkList("abcde", 4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList5_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "a", "b", "c", "d", "e" };

            // Act
            List<string> actual = chunker.ChunkList("abcde", 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList6_OverSizeChunks_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "a", "b", "c", "d", "e" };

            // Act
            List<string> actual = chunker.ChunkList("abcde", 6);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList7_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "abcd", "efg", "hij", "klm" };

            // Act
            List<string> actual = chunker.ChunkList("abcdefghijklm", 4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList8_ValidInput_ReturnsCorrectChunks()
        {
            // Expected
            List<string> expected = new List<string> { "abc", "def", "ghi", "jk", "lm" };

            // Act
            List<string> actual = chunker.ChunkList("abcdefghijklm", 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChunkList9_EmptyList_ReturnsCorrectChunks()
        {
            // Act
            List<string> actual = chunker.ChunkList("", 5);

            // Assert
            Assert.Empty(actual);
        }
    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulationEncora;
using Xunit;
using Assert = Xunit.Assert;

namespace StringEncora.Tests
{
    [TestClass]
    public class ProgramTests
    {
      
        [TestMethod()]
        public void SortStringByCharFrequencyTest1()
        {
            string[] input =           {"dulgvgzwqg", "gxtjtmtywr", "hnlnxiupgt", "gzjotckivp", "dpwwsdptae", 
                                        "pcscpilknb", "btvyhhmflf", "artrtnqxcr", "nrtcmcoadn", "fkdsgnekft" };

            string[] expectedOutput = { "gggdlquvwz", "tttgjmrwxy", "nnghilptux", "cgijkoptvz","ddppwwaest",
                                        "ccppbiklns", "ffhhblmtvy", "rrrttacnqx", "ccnnadmort", "ffkkdegnst" };

            SortingOperations sortString = new SortingOperations();

            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                Assert.Equal(expectedOutput[i], result);
            }
        }

        [TestMethod()]
        public void SortStringByCharFrequencyTest2()
        {
            string[] input =              { "wzenwebuau", "vokfxzynwl", "neldfeyrxk", "wqadfiodgs", "ykiuvzfcbc" };

                string[] expectedOutput = {"eeuuwwabnz", "fklnovwxyz", "eedfklnrxy", "ddafgioqsw", "ccbfikuvyz" };

            SortingOperations sortString = new SortingOperations();

            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                Assert.Equal(expectedOutput[i], result);
            }
        }

        [TestMethod()]
        public void SortStringByCharFrequencyTest3()
        {
            string[] input =           { "qakmc", "rrtbk", "vaixn", "wmpnj", "uproi", "btska", "ejqwr", "elwlg", "oaoiy", "hrqkn" };

            string[] expectedOutput =  { "ackmq", "rrbkt", "ainvx", "jmnpw", "iopru", "abkst", "ejqrw", "llegw", "ooaiy", "hknqr" };

            SortingOperations sortString = new SortingOperations();

            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                Assert.Equal(expectedOutput[i], result);
            }
        }

        [TestMethod()]
        public void SortStringByCharFrequencyTest4()
        {
            string[] input =          { "pzjim", "njnfq", "xyohs"};

            string[] expectedOutput = { "ijmpz", "nnfjq", "hosxy"};

            SortingOperations sortString = new SortingOperations();

            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                Assert.Equal(expectedOutput[i], result);
            }
        }

        [TestMethod()]
        public void SortStringByCharFrequencyTest5()
        {
            string[] input =          { "xqycs", "beoax", "afkso", "bldit", "gwrys" };

            string[] expectedOutput = { "cqsxy", "abeox", "afkos", "bdilt", "grswy" };

            SortingOperations sortString = new SortingOperations();

            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                Assert.Equal(expectedOutput[i], result);
            }
        }

    }
}
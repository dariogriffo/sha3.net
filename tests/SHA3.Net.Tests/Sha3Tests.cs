using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace SHA3.Net.Tests
{
    [TestFixture]
    public class Sha3Tests
    {
        [TestCase("", "6b4e03423667dbb73b6e15454f0eb1abd4597f9a1b078e3f5b5a6bc7")]
        [TestCase("The quick brown fox jumps over the lazy dog", "d15dadceaa4d5d7bb3b48f446421d542e08ad8887305e28d58335795")]
        [TestCase("abc", "e642824c3f8cf24ad09234ee7d3c766fc9a3a5168d0c94ad73b46fdf")]
        [TestCase("abcdbcdecdefdefgefghfghighijhijkijkljklmklmnlmnomnopnopq", "8a24108b154ada21c9fd5574494479ba5c7e7ab76ef264ead0fcce33")]
        public void Sha3224ComputeHash_WithControlledInput_ResultMatchesExpected(string input, string expected)
        {
            var hash = Sha3.Sha3224().ComputeHash(Encoding.UTF8.GetBytes(input));
            hash.ToHexString().Should().Be(expected);
        }

        [TestCase("", "a7ffc6f8bf1ed76651c14756a061d662f580ff4de43b49fa82d80a4b80f8434a")]
        [TestCase("The quick brown fox jumps over the lazy dog", "69070dda01975c8c120c3aada1b282394e7f032fa9cf32f4cb2259a0897dfc04")]
        [TestCase("abc", "3a985da74fe225b2045c172d6bd390bd855f086e3e9d525b46bfe24511431532")]        
        [TestCase("abcdbcdecdefdefgefghfghighijhijkijkljklmklmnlmnomnopnopq", "41c0dba2a9d6240849100376a8235e2c82e1b9998a999e21db32dd97496d3376")]
        public void Sha3256ComputeHash_WithControlledInput_ResultMatchesExpected(string input, string expected)
        {
            var hash = Sha3.Sha3256().ComputeHash(Encoding.ASCII.GetBytes(input));
            hash.ToHexString().Should().Be(expected);
        }

        [TestCase("", "0c63a75b845e4f7d01107d852e4c2485c51a50aaaa94fc61995e71bbee983a2ac3713831264adb47fb6bd1e058d5f004")]
        [TestCase("The quick brown fox jumps over the lazy dog", "7063465e08a93bce31cd89d2e3ca8f602498696e253592ed26f07bf7e703cf328581e1471a7ba7ab119b1a9ebdf8be41")]
        [TestCase("abc", "ec01498288516fc926459f58e2c6ad8df9b473cb0fc08c2596da7cf0e49be4b298d88cea927ac7f539f1edf228376d25")]
        [TestCase("abcdbcdecdefdefgefghfghighijhijkijkljklmklmnlmnomnopnopq", "991c665755eb3a4b6bbdfb75c78a492e8c56a22c5c4d7e429bfdbc32b9d4ad5aa04a1f076e62fea19eef51acd0657c22")]
        public void Sha3384ComputeHash_WithControlledInput_ResultMatchesExpected(string input, string expected)
        {
            var hash = Sha3.Sha3384().ComputeHash(Encoding.UTF8.GetBytes(input));
            hash.ToHexString().Should().Be(expected);
        }

        [TestCase("", "a69f73cca23a9ac5c8b567dc185a756e97c982164fe25859e0d1dcc1475c80a615b2123af1f5f94c11e3e9402c3ac558f500199d95b6d3e301758586281dcd26")]
        [TestCase("The quick brown fox jumps over the lazy dog", "01dedd5de4ef14642445ba5f5b97c15e47b9ad931326e4b0727cd94cefc44fff23f07bf543139939b49128caf436dc1bdee54fcb24023a08d9403f9b4bf0d450")]
        [TestCase("abc", "b751850b1a57168a5693cd924b6b096e08f621827444f70d884f5d0240d2712e10e116e9192af3c91a7ec57647e3934057340b4cf408d5a56592f8274eec53f0")]
        [TestCase("abcdbcdecdefdefgefghfghighijhijkijkljklmklmnlmnomnopnopq", "04a371e84ecfb5b8b77cb48610fca8182dd457ce6f326a0fd3d7ec2f1e91636dee691fbe0c985302ba1b0d8dc78c086346b533b49c030d99a27daf1139d6e75e")]
        public void Sha3512ComputeHash_WithControlledInput_ResultMatchesExpected(string input, string expected)
        {
            var hash = Sha3.Sha3512().ComputeHash(Encoding.UTF8.GetBytes(input));
            hash.ToHexString().Should().Be(expected);
        }
        
        [TestCase(224)]
        [TestCase(256)]
        [TestCase(384)]
        [TestCase(512)]
        public void HashSize_Returns_The_Correct_Value(int size)
        {
            var hash = new Sha3(size);
            hash.HashSize.Should().Be(size);
        }
    }
}

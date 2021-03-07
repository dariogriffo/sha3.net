using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SHA3.Net.Tests")]

namespace SHA3.Net
{
    using Org.BouncyCastle.Crypto.Digests;

    public class Sha3 : System.Security.Cryptography.HashAlgorithm
    {
        private readonly Sha3Digest _digest;
        private readonly int _hashBitLength;

        public override int HashSize => _hashBitLength;

        public static Sha3 Sha3224()
        {
            return new Sha3(224);
        }

        public static Sha3 Sha3256()
        {
            return new Sha3(256);
        }

        public static Sha3 Sha3384()
        {
            return new Sha3(384);
        }

        public static Sha3 Sha3512()
        {
            return new Sha3(512);
        }

        internal Sha3(int hashBitLength)
        {
            _hashBitLength = hashBitLength;
            _digest = new Sha3Digest(_hashBitLength);
        }

        public override void Initialize()
        {
            HashValue = new byte[_digest.GetDigestSize()];
        }
        
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (HashValue == null)
            {
                Initialize();
            }
            _digest.BlockUpdate(array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            _digest.DoFinal(HashValue, 0);
            return HashValue;
        }
    }
}

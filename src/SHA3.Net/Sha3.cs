using Org.BouncyCastle.Crypto.Digests;

namespace SHA3.Net
{
    public class Sha3 : System.Security.Cryptography.HashAlgorithm
    {
        private readonly Sha3Digest _digest;

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
        private Sha3(int hashBitLength)
        {
            _digest = new Sha3Digest(hashBitLength);
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

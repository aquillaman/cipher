namespace Cipher.Core.Interfaces
{
    internal interface ICipher: IEncryptor, IDecryptor
    {
        string Name { get; }
    }
}
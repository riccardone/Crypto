using System;
using NUnit.Framework;

namespace Crypto.Tests
{
    public class AesCryptoServiceTests
    {

        [Test]
        public void Given_Im_a_message_processor_When_I_receive_a_message_Then_I_encrypt_it()
        {
            // Assign
            const string clearTextMessage = "test";
            var key = Convert.FromBase64String("3x+bfONnKwILntoe1hBELOpD1u+1cp2ZceRVnbW2fAs=");
            var sut = new AesCryptoService(key);

            // Act
            var encryptedMessage = sut.Encrypt(clearTextMessage);
            var decryptedMessage = sut.Decrypt(encryptedMessage);

            // Assert
            Assert.IsTrue(clearTextMessage.Equals(decryptedMessage));
        }
    }
}
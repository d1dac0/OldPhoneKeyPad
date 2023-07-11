using FluentAssertions;

namespace OldPhoneKeyPad.Test.KeyPadTests
{
    public class KeyPadTests
    {
        
        [Theory]
        [InlineData("33#","e")]
        [InlineData("227*#", "b")]
        [InlineData("4433555 555666#", "hello")]
        [InlineData("8 88777444666*664#", "turing")]
        public void KeyPad_OldPhonePad_ReturnString(string input, string expected)
        {
            //Arrange            

            //Act
            var result = KeyPad.OldPhonePad(input);

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be(expected);                        
        }
    }
}

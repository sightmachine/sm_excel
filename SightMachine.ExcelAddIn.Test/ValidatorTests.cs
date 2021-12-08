using ExcelAddIn.Exception;
using ExcelAddIn.Helper;
using NUnit.Framework;

namespace SightMachine.ExcelAddIn.Test
{
    [TestFixture]
    public class ValidatorTests
    {
        [TestCase]
        public void HandleNullOrWhiteSpaceRequired_WithValidValue_ShouldPass()
        {
            // Arrange
            var textBox = new System.Windows.Forms.TextBox { Text = @"Dummy Name" };

            // Act
            Validator.HandleNullOrWhiteSpaceRequired(textBox, "Dummy Name");

            // Assert
        }

        [TestCase]
        public void HandleNullOrWhiteSpaceRequired_WithEmptyValue_ShouldThrowException()
        {
            // Arrange
            var textBox = new System.Windows.Forms.TextBox {Text = string.Empty };

            // Act
            // Assert
            Assert.Throws<ValidationException>(() => Validator.HandleNullOrWhiteSpaceRequired(textBox, "Dummy Name"));
        }

        [TestCase]
        public void HandleNullOrWhiteSpaceRequired_WithNullValue_ShouldThrowException()
        {
            // Arrange
            var textBox = new System.Windows.Forms.TextBox { Text = null };

            // Act
            // Assert
            Assert.Throws<ValidationException>(() => Validator.HandleNullOrWhiteSpaceRequired(textBox, "Dummy Name"));
        }
    }
}
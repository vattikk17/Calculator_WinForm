using LAB1_TP;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
           public void BtnEquals_Click_Addition_Test()
            {
                // Arrange
                Calculator.TextDisplay1.Text = "2";
                Calculator.operation = "+";
                Calculator.result = 3;

                // Act
                Calculator.BtnEquals_Click(null, EventArgs.Empty);

                // Assert
                Assert.AreEqual("5", Calculator.TextDisplay1.Text);
                Assert.AreEqual("3 2=5", Calculator.TextDisplay2.Text);
                Assert.AreEqual("3+2 = 5\n", Calculator.RtBoxDisplayHistory.Text);
                Assert.AreEqual("", Calculator.operation);
            }
        }
    }


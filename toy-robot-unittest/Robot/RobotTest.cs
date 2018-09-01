using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;
using ToyRobot;

namespace ToyRobotTest
{
	[TestClass]
	public class RobotTest
	{
		[TestMethod]
		public void RobotPosition_InitializeRobot_RobotShouldHaveValidPositionAtInitialization()
		{
			//Arrange
			Robot robot = new Robot();
			Position position;

			//Act
			position = robot.CurrentPosition;

			//Assert
			Assert.AreEqual(0, position.x, "Current position of Robot at x axis is not on table");
			Assert.AreEqual(0, position.y, "Current position of Robot at y axis is not on table");
			Assert.AreEqual("", position.direction, "Current direction of table is not yet set");
		}
	}
}

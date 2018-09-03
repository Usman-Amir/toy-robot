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
			position = robot.CurrentPosition();

			//Assert
			Assert.AreEqual(0, position.x, "Current position of Robot at x axis is not on table");
			Assert.AreEqual(0, position.y, "Current position of Robot at y axis is not on table");
			Assert.AreEqual("", position.direction, "Current direction of table is not yet set");
		}
		public void RobotPosition_SettingThePositionOfRobot_RobotPositionShouldSet()
		{
			//Arrange
			Robot robot = new Robot();
			bool IsPositionSet;

			//Act
			IsPositionSet = robot.SetPosition(new Position(5, 5, "NORTH"));

			//Assert
			Assert.AreEqual(true, IsPositionSet, "New Position of robot not set");
		}
		public void RobotPosition_InitializeRobot_RobotShouldNotAliveAsThereIsNoDirectino()
		{
			//Arrange
			Robot robot = new Robot();
			bool isAlive;
			
			//Act
			isAlive = robot.IsAlive();

			//Assert
			Assert.AreEqual(false, isAlive, "Direction of robot is not yet set");
		}
	}
}

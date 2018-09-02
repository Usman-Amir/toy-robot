using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;
using ToyRobot;

namespace ToyRobotTest
{
	[TestClass]
	public class RotateCommandTest
	{
		[TestMethod]
		public void RotateRobot_GivenTheDirectionToNorth_RobotShouldMoveToWest()
		{
			Robot robot = new Robot();
			new RotateCommand(robot).execute(new Position(3, 4, "NORTH"), -1);
			Assert.AreEqual("WEST", robot.CurrentPosition.direction, "The Intended position of robot is not correct, it should be west");
		}

		[TestMethod]
		public void RotateRobot_GivenTheDirectionToWest_RobotShouldMoveToNorth()
		{
			Robot robot = new Robot();
			new RotateCommand(robot).execute(new Position(3, 4, "WEST"), 1);
			Assert.AreEqual("NORTH", robot.CurrentPosition.direction, "The Intended position of robot is not correct, it should be north");
		}
	}
}

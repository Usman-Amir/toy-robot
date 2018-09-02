using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;
using ToyRobot;

namespace ToyRobotTest
{
	[TestClass]
	public class MoveCommandTest
	{
		[TestMethod]
		public void MoveRobot_MoveRobotToOneStepFromTheEdgeofTable_ShouldNotMoveTheRobotAsItWasAlreadyOnEdge()
		{
			//Arrange
			Robot robot = new Robot();
			MoveCommand moveCommand = new MoveCommand(robot);
			Table table = new Table(5, 5);
			Position nextposition;
			bool IsValidPosition;
			//Act
			nextposition = moveCommand.getNextPosition(new Position(1, 1, "NORTH"));
			IsValidPosition = moveCommand.execute(nextposition);

			//Assert
			Assert.AreEqual(false, nextposition, "Please provide the valid new position for the robot to move");
		}
	}
}

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

		[TestMethod]
		public void MoveRobot_MoveRobotToOneStepFromNotTheEdgeofTable_ShouldMoveTheRobotAsItWasNotOnEdge()
		{
			//Arrange
			Robot robot = new Robot();
			MoveCommand moveCommand = new MoveCommand(robot);
			Table table = new Table(5, 5);
			Position nextposition;
			bool IsValidPosition;
			//Act
			nextposition = moveCommand.getNextPosition(new Position(1, 1, "SOUTH"));
			IsValidPosition = moveCommand.execute(nextposition);

			//Assert
			Assert.AreEqual(true, nextposition, "Please provide the valid new position for the robot to move");
		}

		[TestMethod]
		public void MoveRobot_GettingTheNExtPossiblePositionForNextMove_ShouldMoveTheRobotOneStepWest()
		{
			//Arrange
			Robot robot = new Robot();
			MoveCommand moveCommand = new MoveCommand(robot);
			Table table = new Table(5, 5);
			Position nextposition;
			
			//Act
			nextposition = moveCommand.getNextPosition(new Position(5, 5, "WEST"));

			//Assert
			Assert.AreEqual(4, nextposition.x, "The Next position in the west direction is not valid on the table");
		}

		[TestMethod]
		public void MoveRobot_GettingTheNExtPossiblePositionForNextMove_ShouldMoveTheRobotOneStepEast()
		{
			//Arrange
			Robot robot = new Robot();
			MoveCommand moveCommand = new MoveCommand(robot);
			Table table = new Table(5, 5);
			Position nextposition;
			
			//Act
			nextposition = moveCommand.getNextPosition(new Position(2, 3, "EAST"));

			//Assert
			Assert.AreEqual(3, nextposition.x, "The Next position in the east direction is not valid on table");
		}
	}
}

using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;
using ToyRobot;

namespace ToyRobotTest
{
	[TestClass]
	public class PlaceCommandTest
	{
		[TestMethod]
		public void CommandForRobot_PlaceInvalidPositionOnTable_ShouldNotPlaceRobotForInvalidPositino()
		{
			Robot robot = new Robot();
			PlaceCommand placecommand = new PlaceCommand(robot);
			Table table = new Table(5, 5);
			bool IsCommandPlaced;

			IsCommandPlaced = placecommand.execute(new Position(11, 4, "NORTH"));

			Assert.AreEqual(true,IsCommandPlaced, "The Place command is not valid");
		}
		[TestMethod]
		public void CommandForRobot_PlaceValidPositionOnTable_ShouldPlaceRobotForValidPositino()
		{
			Robot robot = new Robot();
			PlaceCommand placecommand = new PlaceCommand(robot);
			Table table = new Table(5, 5);
			bool IsCommandPlaced;

			IsCommandPlaced = placecommand.execute(new Position(3, 4, "NORTH"));

			Assert.AreEqual(true, IsCommandPlaced, "The Place command is not valid");
		}
	}
}

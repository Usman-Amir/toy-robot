using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;
using ToyRobot;


namespace ToyRobotTest
{
	[TestClass]
	public class TableTest
	{
		[TestMethod]
		public void TablePosition_SetPositionofTable_RobotIsOnValidPosition()
		{
			//arrange
			Table table = new Table(5, 5);
			Position position = new Position(1,1, "NORTH");

			//act
			bool tablePosition = table.IsPositionValid(position);

			//assert
			Assert.AreEqual(true, tablePosition, "The position of robot is not on the table");
		}

		[TestMethod]
		public void TablePosition_SetInvalidPositionofTable_RobotIsOnInValidPosition()
		{
			//arrange
			Table table = new Table(5, 5);
			Position position = new Position(10, 10, "NORTH");

			//act
			bool tablePosition = table.IsPositionValid(position);

			//assert
			Assert.AreEqual(false, tablePosition, "The position of robot is not on the table");
		}
	}
}

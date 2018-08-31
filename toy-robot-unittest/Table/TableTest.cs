using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;


namespace toy_robot_unittest
{
	[TestClass]
	public class TableTest
	{
		[TestMethod]
		public void TablePosition_SetPositionofTable_RobotIsOnValidPosition()
		{
			//arrange
			toy_robot.Table table = new toy_robot.Table(5, 5);
			toy_robot.Position position = new toy_robot.Position(1,1, "NORTH");

			//act
			bool tablePosition = table.IsPositionValid(position);

			//assert
			Assert.AreEqual(true, tablePosition, "The position of robot is not on the table");
		}

		[TestMethod]
		public void TablePosition_SetInvalidPositionofTable_RobotIsOnInValidPosition()
		{
			//arrange
			toy_robot.Table table = new toy_robot.Table(5, 5);
			toy_robot.Position position = new toy_robot.Position(10, 10, "NORTH");

			//act
			bool tablePosition = table.IsPositionValid(position);

			//assert
			Assert.AreEqual(false, tablePosition, "The position of robot is not on the table");
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using toy_robot;


namespace toy_robot_unittest
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
	}
}

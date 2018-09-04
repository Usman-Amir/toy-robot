using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;
using ToyRobot;

namespace ToyRobotTest
{
	[TestClass]
	public class IntegrationTest
	{
		
		[TestMethod]
		public void IntegratedFlow_ExampleA()
		{
			Robot robot;
			RobotCommander commander;
			string response;
			InitializeRobot(out robot, out commander, out response);

			commander.execute("PLACE 0,0,NORTH");
			commander.execute("MOVE");
			response = commander.execute("REPORT");
			Assert.AreEqual(0, robot.position.x, "Current x position of robot is not valid");
			Assert.AreEqual(1, robot.position.y, "Current y position of robot is not valid");
			Assert.AreEqual("NORTH", robot.position.direction, "Current direction of robot is not valid");
		}

		[TestMethod]
		public void IntegratedFlow_ExampleB()
		{
			Robot robot;
			RobotCommander commander;
			string response;
			InitializeRobot(out robot, out commander, out response);

			commander.execute("PLACE 1,2,EAST");
			commander.execute("MOVE");
			commander.execute("MOVE");
			commander.execute("LEFT");
			commander.execute("MOVE");
			response = commander.execute("REPORT");
			Assert.AreEqual(3, robot.position.x, "Current x position of robot is not valid");
			Assert.AreEqual(3, robot.position.y, "Current y position of robot is not valid");
			Assert.AreEqual("NORTH", robot.position.direction, "Current direction of robot is not valid");
		}

		[TestMethod]
		public void IntegratedFlow_ExampleC()
		{
			Robot robot;
			RobotCommander commander;
			string response;
			InitializeRobot(out robot, out commander, out response);

			commander.execute("PLACE 0,0,NORTH");
			commander.execute("LEFT");
			response = commander.execute("REPORT");
			Assert.AreEqual(0, robot.position.x, "Current x position of robot is not valid");
			Assert.AreEqual(0, robot.position.y, "Current y position of robot is not valid");
			Assert.AreEqual("WEST", robot.position.direction, "Current direction of robot is not valid");
		}

		[TestMethod]
		public void IntegratedFlow_ExampleD()
		{
			Robot robot;
			RobotCommander commander;
			string response;
			InitializeRobot(out robot, out commander, out response);

			commander.execute("PLACE 5,5,NORTH");
			commander.execute("LEFT");
			commander.execute("LEFT");
			commander.execute("LEFT");
			commander.execute("LEFT");
			response = commander.execute("REPORT");
			Assert.AreEqual(5, robot.position.x, "Current x position of robot is not valid");
			Assert.AreEqual(5, robot.position.y, "Current y position of robot is not valid");
			Assert.AreEqual("NORTH", robot.position.direction, "Current direction of robot is not valid");
		}
		[TestMethod]
		public void IntegratedFlow_ExampleE()
		{
			Robot robot;
			RobotCommander commander;
			string response;
			InitializeRobot(out robot, out commander, out response);

			commander.execute("PLACE 5,5,NORTH");
			commander.execute("MOVE");
			commander.execute("MOVE");
			commander.execute("MOVE");
			commander.execute("MOVE");
			commander.execute("MOVE");
			commander.execute("LEFT");
			commander.execute("LEFT");
			commander.execute("LEFT");
			response = commander.execute("REPORT");
			Assert.AreEqual(5, robot.position.x, "Current x position of robot is not valid");
			Assert.AreEqual(10, robot.position.y, "Current y position of robot is not valid");
			Assert.AreEqual("EAST", robot.position.direction, "Current direction of robot is not valid");
		}


		private static void InitializeRobot(out Robot robot, out RobotCommander commander, out string response)
		{
			Table table = new Table(5, 5);
			robot = new Robot();
			commander = new RobotCommander(robot, table);
			response = "";
		}
	}
}

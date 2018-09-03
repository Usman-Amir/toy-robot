using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	class Program
	{
		static void Main(string[] args)
		{
			Table table = new Table(5, 5);
			Robot robot = new Robot();
			RobotCommander commander = new RobotCommander(robot, table);

			commander.execute("PLACE 0,0,NORTH");
			commander.execute("MOVE");
			string finalPosition =  commander.execute("REPORT");

			Console.WriteLine(finalPosition);

		}
	}
}

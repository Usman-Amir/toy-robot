using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToyRobot
{
	public class InputCommandParser
	{
		static Regex placeRegex = new Regex(@"/^\s*PLACE\s+([\d]+)\s*,\s*([\d]+)\s*,\s*(EAST|WEST|NORTH|SOUTH)\s*$");
		static Regex moveRegex = new Regex(@"^\s*MOVE\s*$");
		static Regex leftRegex = new Regex(@"/^\s*LEFT\s*$");
		static Regex rightRegex = new Regex(@"/^\s*RIGHT\s*$");
		static Regex reportRegex = new Regex(@"/^\s*REPORT\s*$/");

		public static int parse(string input)
		{
			if (placeRegex.Match(input).Success)
				return (int)Command.RobotCommand.PLACE;
			else if (moveRegex.Match(input).Success)
				return (int)Command.RobotCommand.MOVE;
			else if (leftRegex.Match(input).Success)
				return (int)Command.RobotCommand.LEFT;
			else if (rightRegex.Match(input).Success)
				return (int)Command.RobotCommand.RIGHT;
			else if (reportRegex.Match(input).Success)
				return (int)Command.RobotCommand.REPORT;
			return -1;
		}
	}
}

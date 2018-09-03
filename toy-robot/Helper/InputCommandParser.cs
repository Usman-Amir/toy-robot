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
		static Regex placeRegex = new Regex(@"(?i)PLACE\s+([\d]+),([\d]+),(east|west|north|south)$");
		static Regex moveRegex = new Regex(@"(?i)(MOVE)");
		static Regex leftRegex = new Regex(@"(?i)(LEFT)");
		static Regex rightRegex = new Regex(@"(?i)(RIGHT)");
		static Regex reportRegex = new Regex(@"(?i)(REPORT)");

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

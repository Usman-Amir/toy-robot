using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	public class RobotCommander
	{
		public Table table;
		public Robot robot;

		public RobotCommander(Robot robot, Table table)
		{
			this.robot = robot;
			this.table = table;
		}
		public string execute(string input)
		{

			string response= "";
			int LEFT_MOVE = -1;
			int RIGHT_MOVE = 1;


			Position currentPosition = this.robot.CurrentPosition();
			int parsedCommand = InputCommandParser.parse(input);

			switch ((Command.RobotCommand)parsedCommand)
			{
				case Command.RobotCommand.PLACE:
					string[] splittedCommand = input.Split(null)[1].Split(',');
					Position position = new Position(int.Parse(splittedCommand[0]), int.Parse(splittedCommand[1]), splittedCommand[2]);
					(new PlaceCommand(this.robot)).execute(position);
					break;
				case Command.RobotCommand.MOVE:
					if (this.robot.IsAlive())
					{
						MoveCommand move = new MoveCommand(this.robot);
						Position p = new Position(currentPosition.x, currentPosition.y, currentPosition.direction);
						move.execute((new MoveCommand(this.robot).getNextPosition(p)));
					}
					break;
				case Command.RobotCommand.LEFT:
					if (this.robot.IsAlive())
					{
						(new RotateCommand(this.robot)).execute(currentPosition, LEFT_MOVE);
					}
					break;
				case Command.RobotCommand.RIGHT:
					if (this.robot.IsAlive())
					{
						(new RotateCommand(this.robot)).execute(currentPosition, RIGHT_MOVE);
					}
					break;
				case Command.RobotCommand.REPORT:
					if (this.robot.IsAlive())
					{
						response = string.Format("{0} {1} {2}", this.robot.CurrentPosition().x, this.robot.CurrentPosition().y, this.robot.CurrentPosition().direction);
					}
					else
						Console.WriteLine("Lets get started by issuing the 'PLACE' command.");
					break;
				default:
					Console.WriteLine(parsedCommand);
					break;
			}
			return response;
		}
	}
}

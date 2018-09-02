using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	public class RotateCommand : AbstractCommand
	{
		public RotateCommand(Robot robot) : base(robot)
		{
		}
		public void execute(Position position, int step)
		{
			Position newPosition = position;
			int index = (int)Enum.Parse(typeof(Direction.directionEnum), position.direction) + step;
			if (index < 0)
				index = Enum.GetNames(typeof(Direction.directionEnum)).Length - 1;
			else
				index = index % Enum.GetNames(typeof(Direction.directionEnum)).Length;

			Direction.directionEnum de = (Direction.directionEnum)index;
			newPosition.direction = de.ToString();
			this.robot.SetPosition(newPosition);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot;

namespace ToyRobot
{
	public class Robot
	{
		public Position position;

		public Robot()
		{
			position = new Position(0,0,"");
		}
		/*
      Gets the current position of the robot.
     */
		public Position CurrentPosition
		{
			get
			{
				return position;
			}
		}
		public bool SetPosition(Position position)
		{
			this.position = new Position(position.x, position.y, position.direction);
			return true;
		}

		public bool IsAlive
		{
			get
			{
				if (string.IsNullOrEmpty(this.position.direction))
					return false;
				else
					return true;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	public class PlaceCommand : AbstractCommand
	{
		public PlaceCommand(Robot robot) : base(robot)
		{
		}

		public override bool execute(Position position)
		{
			return base.execute(position);
		}
	}
}

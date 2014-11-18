using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRaff;

namespace Flick
{
	class Wall : GameElement
	{
		private Color _color;
		private Rectangle _area;

		public Wall(Rectangle area, Color color)
		{
			_area = area;
			_color = color;
		}

		public override void OnDraw()
		{
			Fill.Rectangle(_color, _area);
		}
	}
}

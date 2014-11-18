using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRaff;
using GRaff.Particles;

namespace Flick
{
	class Shape : MovingObject, IMousePressListener
	{
        private Color _color;
		private double _scale = 2.0;

		private static Shape _draggedObject = null;

		public Shape(double x, double y, Color color)
			: base(x, y)
		{
			Velocity = GRandom.Vector() * 15;
			Mask.Shape = MaskShape.Circle(30);
			_scale = GRandom.Double(0.2, 3.0);
			Friction = GRandom.Double(0.05);
			_color = color;
		}

		public override void OnDraw()
		{
			Fill.Circle(_color, Location, 30 * _scale);
			this.Transform.Scale *= _scale;
		}

		public override void OnStep()
		{


			if (Location.X <= 0 || Location.X >= Room.Width)
			{
				HSpeed *= -1;
			}

			if (Location.Y <= 0 || Location.Y >= Room.Height)
			{
				VSpeed *= -1;
			}
		}

		public void OnMousePress(MouseButton button)
		{
			_draggedObject = this;
		}
	}
}

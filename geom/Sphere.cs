﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace geom
{
	[System.ComponentModel.TypeConverter(typeof(geom.StructTypeConverter<Sphere>))]
	public struct Sphere
	{
		public Vector3 position;
		public float radius;

		public Sphere (Vector3 pos, float radius) {
			position=pos;
			this.radius=radius;
		}
	}
}

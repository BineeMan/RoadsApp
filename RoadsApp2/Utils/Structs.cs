﻿using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls.Shapes;
using System.Net;

namespace RoadsApp2.Utils
{
    public class Structs
    {
        public struct Node
        {
            public Rectangle Rectangle { get; set; }

            public Rectangle OriginalRectangle { get; set; }
            public List<Image> PlusButtons { get; set; }
            public List<Link> Roads { get; set; }

            public int Side1ExtendedTimes { get; set; } //Up

            public int Side2ExtendedTimes { get; set; } //Down

            public int Side3ExtendedTimes { get; set; } //Right

            public int Side4ExtendedTimes { get; set; } //Left
            public bool isActive { get; set; }
        }

        public struct Vector
        {
            public Point point1 { get; set; }
            public Point point2 { get; set; }
            public bool Equals(Vector vector)
            {
                return vector.point1 == this.point1 || vector.point2 == this.point2;
            }
        }

        public struct Link
        {
            public Polygon Road { get; set; }
            public PointCollection OriginalRoadPoints { get; set; }
            public List<Line> LinesSide1 { get; set; }
            public List<Line> LinesSide2 { get; set; }
            public List<Line> MiddleLines { get; set; }
            public List<LineStepper> LineSteppers { get; set; }
            public Rectangle RectangleCollision { get; set; }
            public bool IsTwoLaned { get; set; }
        }

        public struct LineStepper
        {
            public Stepper Stepper { get; set; }
            public Vector Vector { get; set; }

        }
    }
}

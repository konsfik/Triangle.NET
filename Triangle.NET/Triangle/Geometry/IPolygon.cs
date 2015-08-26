﻿// -----------------------------------------------------------------------
// <copyright file="IPolygon.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace TriangleNet.Geometry
{
    using System.Collections.Generic;
    using TriangleNet.Topology;

    /// <summary>
    /// Polygon interface.
    /// </summary>
    public interface IPolygon
    {
        /// <summary>
        /// Gets the vertices of the polygon.
        /// </summary>
        List<Vertex> Points { get; }

        /// <summary>
        /// Gets the segments of the polygon.
        /// </summary>
        List<ISegment> Segments { get; }

        /// <summary>
        /// Gets a list of points defining the holes of the polygon.
        /// </summary>
        List<Point> Holes { get; }

        /// <summary>
        /// Gets a list of pointers defining the regions of the polygon.
        /// </summary>
        List<RegionPointer> Regions { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the vertices have marks or not.
        /// </summary>
        bool HasPointMarkers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the segments have marks or not.
        /// </summary>
        bool HasSegmentMarkers { get; set; }

        /// <summary>
        /// Adds a contour to the polygon.
        /// </summary>
        /// <param name="points">Points making up the contour.</param>
        /// <param name="marker">Contour marker.</param>
        /// <param name="hole">Treat contour as a hole (interior boundary).</param>
        /// <param name="convex">The hole is convex.</param>
        void AddContour(IEnumerable<Vertex> points, int marker, bool hole, bool convex);

        /// <summary>
        /// Adds a contour to the polygon.
        /// </summary>
        /// <param name="points">Points making up the contour.</param>
        /// <param name="marker">Contour marker.</param>
        /// <param name="hole">Point inside the contour, making it a hole.</param>
        void AddContour(IEnumerable<Vertex> points, int marker, Point hole);

        /// <summary>
        /// Compute the bounds of the polygon.
        /// </summary>
        /// <returns>Rectangle defining an axis-aligned bounding box.</returns>
        Rectangle Bounds();
    }
}

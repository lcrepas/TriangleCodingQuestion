namespace TriangleCodingQuestion
{
    public class TriangleCoordinate
    {
        public int V1X { get; }
        public int V1Y { get; }
        public int V2X { get; }
        public int V2Y { get; }
        public int V3X { get; }
        public int V3Y { get; }

        public TriangleCoordinate(int v1X, int v1Y, int v2X, int v2Y, int v3X, int v3Y)
        {
            V1X = v1X;
            V1Y = v1Y;
            V2X = v2X;
            V2Y = v2Y;
            V3X = v3X;
            V3Y = v3Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((TriangleCoordinate)obj);
        }

        public bool Equals(TriangleCoordinate triangleCoordinate)
        {
            return (V1X == triangleCoordinate.V1X) &&
                   (V1Y == triangleCoordinate.V1Y) &&
                   (V2X == triangleCoordinate.V2X) &&
                   (V2Y == triangleCoordinate.V2Y) &&
                   (V3X == triangleCoordinate.V3X) &&
                   (V3Y == triangleCoordinate.V3Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                
                hash = hash * 23 + V1X.GetHashCode();
                hash = hash * 23 + V1Y.GetHashCode();
                hash = hash * 23 + V2X.GetHashCode();
                hash = hash * 23 + V2Y.GetHashCode();
                hash = hash * 23 + V3X.GetHashCode();
                hash = hash * 23 + V3Y.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(TriangleCoordinate coordinate1, TriangleCoordinate coordinate2)
        {
            if (coordinate1 == null) return false;
            return coordinate1.Equals(coordinate2);
        }

        public static bool operator !=(TriangleCoordinate coordinate1, TriangleCoordinate coordinate2)
        {
            if (coordinate1 == null) return false;
            return !coordinate1.Equals(coordinate2);
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace TriangleCodingQuestion
{
    public class ImageCalculator
    {
        public string GetImageTriangle(string[] args)
        {
            if (args.Length != 6)
            {
                return "Six arguments not provided.  Proper usage is: TriangleCodingQuestion.exe <V1X> <V1Y> <V2X> <V2Y> <V3X> <V3Y>";
            }

            var coordinates = new int[6];
            for (int i = 0; i < 6; i++)
            {
                bool isInteger = int.TryParse(args[i], out coordinates[i]);
                if (!isInteger)
                {
                     return "Please provide only integers as arguments for coordinates.";
                }
            }

            var triangleCoordinates = new TriangleCoordinate(coordinates[0], coordinates[1], coordinates[2], coordinates[3], coordinates[4], coordinates[5]);

            IDictionary<TriangleCoordinate, string> imageTriangles = PopulateImageTriangles();

            string imageRowColumn = GetImageTriangle(imageTriangles, triangleCoordinates);

            return string.IsNullOrWhiteSpace(imageRowColumn) ? 
                "Image triangle not found for supplied coordinates" : 
                imageRowColumn;
        }


        private static IDictionary<TriangleCoordinate, string> PopulateImageTriangles()
        {
            var imageTriangles = new Dictionary<TriangleCoordinate, string>();

            var rows = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F' };

            const int imageHeight = 60;
            const int numberOfColumns = 12;
            const int triangleHeight = 10;
            const int triangleWidth = 10;

            int left = 0;
            int right = 0 + triangleWidth;

            for (int i = 0; i < numberOfColumns; i++)
            {
                i++;

                int oddColumn = i;
                int evenColumn = i + 1;

                int top = imageHeight;
                int bottom = imageHeight - triangleHeight;

                foreach (var row in rows)
                {
                    var oddCoordinate = new TriangleCoordinate(left, bottom, left, top, right, bottom);
                    imageTriangles.Add(oddCoordinate, $"{row}{oddColumn}");

                    var evenCoordinate = new TriangleCoordinate(right, top, right, bottom, left, top);
                    imageTriangles.Add(evenCoordinate, $"{row}{evenColumn}");
                    
                    top -= triangleHeight;
                    bottom -= triangleHeight;
                }

                left += triangleWidth;
                right += triangleWidth;
            }

            return imageTriangles;
        }

        private static string GetImageTriangle(IDictionary<TriangleCoordinate, string> imageTriangles, TriangleCoordinate triangleCoordinates)
        {
            return imageTriangles.ContainsKey(triangleCoordinates) ? imageTriangles[triangleCoordinates] : null;
        }
    }
}

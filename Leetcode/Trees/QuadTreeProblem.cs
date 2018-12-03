namespace Leetcode.Trees
{
    class QuadTreeProblem
    {
        // N is a square
        public Node Construct(int[][] grid)
        {
            if (grid == null)
            {
                return null;
            }

            var n = grid.GetLength(0);
            return Construct(ref grid, 0, n, 0, n);
        }

        private Node Construct(ref int[][] grid, int x_start, int x_end, int y_start, int y_end)
        {
            var dimension = x_end - x_start;
            var halfValue = dimension / 2;
            var originValue = grid[x_start][y_start];

            // Last cell
            if (dimension == 1)
            {
                return new Node(originValue == 1, true, null, null, null, null);
            }

            // Check if all elements are same
            var baseValue = originValue;
            bool isLeaf = true;
            for (var i = x_start; i < x_end; i++)
            {
                for (var j = y_start; j < y_end; j++)
                {
                    if (grid[i][j] != baseValue)
                    {
                        isLeaf = false;
                        break;
                    }
                }
            }

            if (isLeaf)
            {
                return new Node(originValue == 1, true, null, null, null, null);
            }
            else
            {
                var topLeft = Construct(ref grid, x_start, x_start + halfValue, y_start, y_start + halfValue);
                var topRight = Construct(ref grid, x_start, x_start + halfValue, y_start + halfValue, y_end);
                var bottomLeft = Construct(ref grid, x_end - halfValue, x_end, y_start, y_start + halfValue);
                var bottomRight = Construct(ref grid, x_end - halfValue, x_end, y_end - halfValue, y_end);

                return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
            }
        }
    }

    class Node
    {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node()
        {
        }

        public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }
}

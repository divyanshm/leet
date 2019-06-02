namespace Leetcode.Random
{
    using System.Collections.Generic;

    // problem 841, Medium
    public class KeysAndRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            Queue<int> keyToProcess = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();

            visited.Add(0);
            foreach(var key in rooms[0])
            {
                keyToProcess.Enqueue(key);
            }

            while (keyToProcess.Count > 0)
            {
                var roomNumber = keyToProcess.Dequeue();

                if (!visited.Contains(roomNumber))
                {
                    foreach (var key in rooms[roomNumber])
                    {
                        keyToProcess.Enqueue(key);
                    }

                    visited.Add(roomNumber);
                }
            }

            return visited.Count == rooms.Count;
        }
    }
}

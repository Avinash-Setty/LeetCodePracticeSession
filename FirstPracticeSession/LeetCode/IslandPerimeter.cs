using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/island-perimeter/
    /// </summary>
    public class IslandPerimeter
    {
        public void Main(int[,] grid)
        {
            var blocks = ConvertToBlocks(grid);
            var islands = GetIslands(blocks);
            var perimeter = GetPerimeter(islands.FirstOrDefault()?.Item2);
            Console.WriteLine(perimeter);
        }

        private int GetPerimeter(List<Block> island)
        {
            if (island == null)
                return 0;

            var sorted = island.OrderBy(i => i.RowIndex).ThenBy(b => b.ColIndex);
            var dict = new Dictionary<string, int>();
            var perimeter = 0;
            foreach (var block in sorted)
            {
                dict[$"{block.RowIndex},{block.ColIndex}"] = block.Value;

                //check top
                int nextRow = block.RowIndex - 1;
                int nextCol = block.ColIndex;
                if (dict.ContainsKey($"{nextRow},{nextCol}"))
                {
                    perimeter = perimeter - 2;
                }

                //check left
                nextRow = block.RowIndex;
                nextCol = block.ColIndex - 1;
                if (dict.ContainsKey($"{nextRow},{nextCol}"))
                {
                    perimeter = perimeter - 2;
                }

                //check bottom
                nextRow = block.RowIndex + 1;
                nextCol = block.ColIndex ;
                if (dict.ContainsKey($"{nextRow},{nextCol}"))
                {
                    perimeter = perimeter - 2;
                }

                //check right
                nextRow = block.RowIndex;
                nextCol = block.ColIndex + 1;
                if (dict.ContainsKey($"{nextRow},{nextCol}"))
                {
                    perimeter = perimeter - 2;
                }

                perimeter = perimeter + 4;
            }


            return perimeter;
        }

        private List<Tuple<int, List<Block>>> GetIslands(List<List<Block>> blocks)
        {
            var response = new List<Tuple<int, List<Block>>>();
            var index = 1;
            foreach (var rowOfBlocks in blocks)
            {
                foreach (var block in rowOfBlocks)
                {
                    if (!block.Visited && block.Value == 1)
                    {
                        var islandBlocks = new List<Block>();
                        GetIslands(block, islandBlocks, blocks);
                        response.Add(new Tuple<int, List<Block>>(index, islandBlocks));
                        index++;
                    }
                }
            }

            return response;
        }

        private void GetIslands(Block block, List<Block> islandBlocks, List<List<Block>> blocks)
        {
            if(block.Visited)
                return;

            block.Visited = true;
            islandBlocks.Add(block);

            // Check Top Block
            var nextRow = block.RowIndex - 1;
            var nextCol = block.ColIndex;
            if (nextRow > -1 && nextRow < blocks.Count && 
                nextCol > -1 && nextCol < blocks[block.RowIndex].Count && 
                blocks[nextRow][nextCol].Value == 1)
            {
                //islandBlocks.Add(blocks[nextRow][nextCol]);
                GetIslands(blocks[nextRow][nextCol], islandBlocks, blocks);
            }

            // Check Left Block
            nextRow = block.RowIndex;
            nextCol = block.ColIndex - 1;
            if (nextRow > -1 && nextRow < blocks.Count &&
                nextCol > -1 && nextCol < blocks[block.RowIndex].Count &&
                blocks[nextRow][nextCol].Value == 1)
            {
                //islandBlocks.Add(blocks[nextRow][nextCol]);
                GetIslands(blocks[nextRow][nextCol], islandBlocks, blocks);
            }

            // Check Right Block
            nextRow = block.RowIndex;
            nextCol = block.ColIndex + 1;
            if (nextRow > -1 && nextRow < blocks.Count &&
                nextCol > -1 && nextCol < blocks[block.RowIndex].Count &&
                blocks[nextRow][nextCol].Value == 1)
            {
                //islandBlocks.Add(blocks[nextRow][nextCol]);
                GetIslands(blocks[nextRow][nextCol], islandBlocks, blocks);
            }

            // Check Bottom Block
            nextRow = block.RowIndex + 1;
            nextCol = block.ColIndex;
            if (nextRow > -1 && nextRow < blocks.Count &&
                nextCol > -1 && nextCol < blocks[block.RowIndex].Count &&
                blocks[nextRow][nextCol].Value == 1)
            {
                //islandBlocks.Add(blocks[nextRow][nextCol]);
                GetIslands(blocks[nextRow][nextCol], islandBlocks, blocks);
            }
        }

        private List<List<Block>> ConvertToBlocks(int[,] grid)
        {
            var response = new List<List<Block>>();
            for (var row = 0; row < grid.GetLength(0); row++)
            {
                var rowData = new List<Block>();
                for (var col = 0; col < grid.GetLength(1); col++)
                {
                    rowData.Add(new Block {Visited = false, Value = grid[row,col], RowIndex = row, ColIndex = col});
                }

                response.Add(rowData);
            }

            return response;
        }
    }

    public class Block
    {
        public bool Visited { get; set; }
        public int Value { get; set; }
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
    }
}

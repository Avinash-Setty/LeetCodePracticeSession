﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/battleships-in-a-board/
    /// </summary>
    public class BattleShipsInBoard
    {
        public void Main()
        {
            
        }

        public int CountBattleShips(char[,] board)
        {
            int m = board.GetLength(0);
            if (m == 0) return 0;
            int n = board.GetLength(1);

            int count = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i,j] == '.') continue;
                    if (i > 0 && board[i - 1,j] == 'X') continue;
                    if (j > 0 && board[i,j - 1] == 'X') continue;
                    count++;
                }
            }

            return count;
        }
    }
}

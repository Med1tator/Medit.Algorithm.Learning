using System;
using System.Collections.Generic;

namespace _006.EightQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            //八皇后：8x8棋盘上横竖以及45°斜角不能出现2个皇后，求所有的摆放
            int[,] chessBoard = new int[8,8];//定义二维数组，默认值均为0；后续拜访皇后，则值修改为1.

            Play(chessBoard, 0);
            Console.ReadKey();
        }

        static void Show(int[,] chessBoard)
        {
            Console.WriteLine($"第{count}种摆法："); count++;
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    Console.Write($"{chessBoard[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        static int count = 1;//摆放的摆法数
        static List<int[,]> EightQueenList = new List<int[,]>();//八皇后集
        static void Play(int[,] chessBoard, int row)
        {
            //遍历当前行所有单元格
            for (int i = 0; i < chessBoard.GetLength(1); i++)
            {
                if (CanPut(chessBoard, row, i))
                {
                    chessBoard[row, i] = 1;//摆放皇后
                    if (row < chessBoard.GetLength(0) - 1)
                    {
                        //还没摆放最后一行，继续摆放
                        Play(chessBoard, row + 1);
                    }
                    else
                    {
                        //所有行都摆放完成，显示棋盘
                        Show(chessBoard);

                        //获取到八皇后
                        EightQueenList.Add(chessBoard);
                    }
                    //回溯。算法的关键地方
                    chessBoard[row, i] = 0;
                }
            }
        }

        static bool CanPut(int[,] chessBoard, int row, int col)
        {
            //默认摆放皇后从上往下摆，则需要判断三个方向是否已经存在皇后，都不存在则可以摆
            //检查上面
            for (int i = row - 1; i >= 0; i--)
            {
                if (chessBoard[i, col] == 1)
                    return false;
            }

            //右上方
            for (int i = row - 1, j = col + 1; i >= 0 && j < chessBoard.GetLength(1); i--, j++)
            {
                if (chessBoard[i, j] == 1)
                    return false;
            }

            //左上方
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (chessBoard[i, j] == 1)
                    return false;
            }

            return true;
        }
    }
}

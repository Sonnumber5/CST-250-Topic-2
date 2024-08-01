using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] TheGrid;

        public Board(int s)
        {
            Size = s;
            TheGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chestPiece)
        {
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    TheGrid[r, c].LegalNextMove = false;
                    TheGrid[r, c].CurrentlyOccupied = false;
                }
            }

            currentCell.CurrentlyOccupied = true;
            switch (chestPiece)
            {
                case "Knight":
                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber - 1 >= 0) TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber + 1 < 8) TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 2 < 8) TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (currentCell.RowNumber + 1 < 8 && currentCell.ColumnNumber + 2 < 8) TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (currentCell.RowNumber + 2 < 8 && currentCell.ColumnNumber + 1 < 8) TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (currentCell.RowNumber + 2 < 8 && currentCell.ColumnNumber - 1 >= 0) TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (currentCell.RowNumber + 1 < 8 && currentCell.ColumnNumber - 2 >= 0) TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 2 >= 0) TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;
                case "King":

                    if (currentCell.RowNumber - 1 >= 0) TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (currentCell.RowNumber + 1 < 8) TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (currentCell.ColumnNumber - 1 >= 0) TheGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (currentCell.ColumnNumber + 1 < 8) TheGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 1>= 0) TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 1 < 8) TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (currentCell.RowNumber + 1 < 8 && currentCell.ColumnNumber - 1 >= 0) TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (currentCell.RowNumber + 1 < 8 && currentCell.ColumnNumber + 1 < 8) TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    break;
                case "Rook":
                    for (int i = 1; i < 8; i++)
                    {
                        if (currentCell.RowNumber + i < 8) TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (currentCell.RowNumber - i >= 0) TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (currentCell.ColumnNumber + i < 8) TheGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (currentCell.ColumnNumber - i >= 0) TheGrid[currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                case "Bishop":
                    for (int i = 1; i < 8; i++)
                    {
                        if (currentCell.RowNumber + i < 8 && currentCell.ColumnNumber + i < 8)
                            TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (currentCell.RowNumber - i >= 0 && currentCell.ColumnNumber + i < 8)
                            TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (currentCell.RowNumber - i >= 0 && currentCell.ColumnNumber - i >= 0)
                            TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (currentCell.RowNumber + i < 8 && currentCell.ColumnNumber - i >= 0)
                            TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                case "Queen":
                    for (int i = 1; i < 8; i++)
                    {
                        if (currentCell.RowNumber + i < 8 && currentCell.ColumnNumber + i < 8)
                            TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (currentCell.RowNumber - i >= 0 && currentCell.ColumnNumber + i < 8)
                            TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (currentCell.RowNumber - i >= 0 && currentCell.ColumnNumber - i >= 0)
                            TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (currentCell.RowNumber + i < 8 && currentCell.ColumnNumber - i >= 0)
                            TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (currentCell.RowNumber + i < 8) TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (currentCell.RowNumber - i >= 0) TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (currentCell.ColumnNumber + i < 8) TheGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (currentCell.ColumnNumber - i >= 0) TheGrid[currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

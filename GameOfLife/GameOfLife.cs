using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife {
    class GameOfLife {
        private bool[,] grid;
        private int rows, columns;
        private int cellWidth;
        private int density;

        private Brush paintBrush;

        public GameOfLife(int rows, int columns, int cellWidth, int density, Brush paintBrush) { // initialize board and fill it with cells at random
            this.rows = rows;
            this.columns = columns;
            this.cellWidth = cellWidth;
            this.density = density;

            this.grid = new bool[rows, columns];

            this.paintBrush = paintBrush;

            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i< this.rows; i++) {
                for (int j=0; j < this.columns; j++) {
                    int randomNumber = random.Next(density);

                    if (randomNumber == 0) 
                        grid[i, j] = true; // if true then live cell is here
                }
            }
        }

        public bool[,] getGrid() {
            return this.grid;
        }

        public bool gridStateEqualsTo(bool[,] anotherGrid) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    if (this.grid[r, c] != anotherGrid[r, c])
                        return false;
                }
            }

            return true;
        }

        public int totalNeighboursAlive(int row, int column) {
            var total = 0;

            // ul
            if ((row - 1 >= 0 && column - 1 >= 0) && (grid[row - 1, column - 1]))
                total++;
            // u
            if ((row - 1 >= 0) && (grid[row - 1, column]))
                total++;
            // ur
            if ((row - 1 >= 0 && column + 1 < columns) && (grid[row - 1, column + 1]))
                total++;
            // r
            if ((column + 1 < columns) && (grid[row, column + 1]))
                total++;
            // lower-right
            if ((row + 1 < rows && column + 1 < rows) && (grid[row + 1, column + 1]))
                total++;
            // lower
            if ((row + 1 < rows) && (grid[row + 1, column]))
                total++;
            // lower-left
            if ((row + 1 < rows && column - 1 >= 0) && (grid[row + 1, column - 1]))
                total++;
            // l
            if ((column - 1 >= 0) && (grid[row, column - 1]))
                total++;

            return total;
        }

        public void swapToNewGeneration() {
            bool[,] newGrid = new bool[rows, columns];

            for (int r = 0; r<grid.GetLength(0); r++ ) {
                for (int c = 0; c<grid.GetLength(1); c++) {

                    int totalNeighbours = totalNeighboursAlive(r, c);

                    if (grid[r, c]) {
                        if (totalNeighbours == 2 || totalNeighbours == 3) {
                            newGrid[r, c] = true;
                        }
                        else {
                            newGrid[r, c] = false;
                        }
                    }
                    else {
                        if (totalNeighbours == 3) {
                            newGrid[r, c] = true;
                        }
                        else {
                            newGrid[r, c] = false;
                        }
                    }
                }
            }
            this.grid = newGrid;
        }

        

        // Drawing
        public void drawGrid(Graphics graphics) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    if (grid[r, c])
                        graphics.FillRectangle(paintBrush, c * cellWidth, r * cellWidth, cellWidth, cellWidth);
                }
            }
        }

        
    }
}

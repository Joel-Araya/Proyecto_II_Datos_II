#include <iostream>
#include "Backtracking.h"

int main() {
    int mazeEx[10][15]={{1,0,0,0,1,0,1,0,0,0,1,0,0,1,0},
                        {1,1,1,0,1,1,1,0,0,0,1,0,0,1,0},
                        {1,0,1,0,1,0,1,0,0,0,1,0,0,1,0},
                        {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                        {0,0,0,1,1,1,1,0,0,0,1,0,0,1,1},
                        {0,0,1,1,1,0,1,0,0,0,1,1,0,1,1},
                        {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                        {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                        {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                        {0,0,1,1,1,0,1,1,1,1,1,0,0,1,1}};
    Backtracking example(mazeEx, 1,1,10,0);
    example.findPath(example.myMaze);
    example.printSol(example.sol);
}
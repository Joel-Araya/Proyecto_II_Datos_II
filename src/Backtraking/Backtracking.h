//
// Created by ignacio on 27/5/21.
//

#ifndef BACKTRACKING_BACKTRACKING_H
#define BACKTRACKING_BACKTRACKING_H


class Backtracking {
public:
    static const int N = 10;
    static const int M = 15;

    Backtracking(int maze[N][M], int startX_, int startY_, int goalX_, int goalY_);

    int myMaze[N][M];
    int startX;
    int startY;
    int goalX;
    int goalY;
    int sol[N][M];


    bool findPath(int maze[N][M]);
    void printSol(int sol[N][M]);

private:

    bool isSafe(int maze[N][M], int x, int y);

    bool solveUtil(int maze[N][M], int x, int y);

};

#endif //BACKTRACKING_BACKTRACKING_H

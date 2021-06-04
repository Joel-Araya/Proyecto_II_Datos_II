//
// Created by ignacio on 29/5/21.
//

#ifndef PATHFINDINGA__PATHFINDINGASTAR_H
#define PATHFINDINGA__PATHFINDINGASTAR_H

#include <list>
#include "StarNode.h"

class PathfindingAStar {
public:
    static const int N = 10;
    static const int M = 15;

    PathfindingAStar(int maze[N][M], int startX_, int startY_, int goalX_, int goalY_);


    int myMaze[N][M];
    int startX;
    int startY;
    int goalX;
    int goalY;
    int sol[N][M];
    StarNode * matrix[N][M];
    std::list<StarNode*> openList;
    std::list<StarNode*> closedList;

    bool findPath();

    bool solveUtil(StarNode* node_);

    void addNeighbors(StarNode *node_);

    bool existsInOpenList(StarNode *node_);

    bool isSafe(int x, int y);

    void createSol(StarNode *node_);

    void printSol(int sol[N][M]);

    bool existsInClosedList(StarNode *node_);
};


#endif //PATHFINDINGA__PATHFINDINGASTAR_H

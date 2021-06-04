cmake_minimum_required(VERSION 3.19)
project(PathfindingA_)

set(CMAKE_CXX_STANDARD 98)


add_executable(PathfindingA_ main.cpp PathfindingAStar.cpp PathfindingAStar.h StarNode.cpp StarNode.h)
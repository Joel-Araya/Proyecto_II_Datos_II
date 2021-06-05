cmake_minimum_required(VERSION 3.17)
project(Proyecto_II_Datos_II)

set(CMAKE_CXX_STANDARD 14)

add_executable(Proyecto_II_Datos_II main.cpp src/Backtraking/Backtracking.cpp src/Backtraking/Backtracking.h src/PathfindingA/PathfindingAStar.cpp src/PathfindingA/PathfindingAStar.h src/PathfindingA/StarNode.cpp src/PathfindingA/StarNode.h)
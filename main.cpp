#include <iostream>
#include "src/PathfindingA/PathfindingAStar.h"
#include "src/Backtraking/Backtracking.h"
#include <iostream>
#include <cstdlib>
#include <string>
#include "src/Server.h"
#include "src/Client.h"
#include "src/Backtraking/Backtracking.h"
#include "src/PathfindingA/PathfindingAStar.h"
#include "src/Genetic/Genetic.cpp"

using namespace std;

/**
 * @brief Contains the logic of the server algorithm
 *
 * @param port of the server
 * @param number of memory space in bytes
 */

int matriz[16][7];
int x, y;

/**
 * @brief Convierte el texto entrante por el socket a una matriz y busca la posicion de la bola
 * es utilizada para el texto entrante en BP game
 *
 * @param text
 */
void analizarBP(string text)
{
    bool guardarFilas = false, pos = false;
    int filas = 0, columnas = 0;
    bool guardarColumnas = false;
    string temp = "";

    for (int i = 0; i < text.size(); i++)
    {
        if (text[i] == '-' && !pos){
            pos = true;
        }
        else if (pos){
            if (text[i] != ',' && text[i] != '-')
            {
                temp += text[i];
            }
            else if(text[i] == ','){
                x = atoi(temp.c_str());
                temp = "";
            }
            else if(text[i] == '-'){
                y = atoi(temp.c_str());
                temp = "";
                pos = false;
            }
        }
        else if (text[i] == '{' && !guardarFilas)
        {
            guardarFilas = true;
        }
        else if (guardarFilas)
        {
            if (text[i] == '{' && !guardarColumnas)
            {
                guardarColumnas = true;
            }
            else if (guardarColumnas)
            {
                if (text[i] != ',' && text[i] != '}')
                {
                    temp = text[i];
                    matriz[filas][columnas] = atoi(temp.c_str());
                    columnas ++;
                }
                else if (text[i] == '}')
                {
                    guardarColumnas = false;
                    columnas = 0;
                    filas ++;
                }
            }
        }
    }
}

/**
 * @brief Recibe una matriz y devuelve la misma matriz concatenada en string para pasar por el socket
 *
 * @param matrizS
 * @return string
 */
string pasar_aString(int matrizS[16][7]){
    string devuelta = "{";
    for(int i = 0; i < 16; i++){
        devuelta += "{";
        for(int j = 0; j < 7; j++){
            if(j == 0){
                devuelta += to_string(matrizS[i][j]);
            }
            devuelta += "," + to_string(matrizS[i][j]);
        }
        devuelta += "}";
        if(i < 15){
            devuelta += ",";
        }
    }
    devuelta += "}";
    return devuelta;
}


int main(int argc, char *argv[]) {

    /**
 * @file main.cpp
 * @author Johnny Aguero
 * @brief Contains the all the logic of the mserver
 * @version 0.1
 * @date 2021-05-05
 *
 * @copyright Copyright (c) 2021
 *
 */


    int puerto = 10000;
    std::string opcion;

    Server *Servidor = new Server(puerto);
    Client *client = new Client();
    opcion = Servidor->Recibir();
    std::string text, enviar, hola;
    int jugada = 0;

    while (true) {
        //BP Game
        if (opcion == "1") {
            if (jugada == 0) {
                //cin>>hola;
                text = Servidor->Recibir();

                cout << text << endl;

                analizarBP(text);
                //PathfindingAStar example(matriz,x,y,16,3);
                //example.findPath();
                //enviar = pasar_aString(example.sol)
                //client->Enviar(enviar);
                jugada = 1;
            } else {
                text = Servidor->Recibir();
                analizarBP(text);
                //Backtracking example(matriz,x,y,0,3);
                //example.findPath(example.myMaze);
                //example.printSol(example.sol);
                //enviar = pasar_aString(example.sol)
                client->Enviar(enviar);
                jugada = 0;
            }
        }
            //Puzzle game
        else if (opcion == "2") {
            return 2;
        }
    }
    return 0;
}







    /*int x = 1;

    if(x==0){
        //Backtracking
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

    } else if (x=1){
        //Pathfinding A*

        int mazeEx2[10][15]={{1,0,0,1,1,0,1,1,1,1,1,0,0,1,0},
                             {1,1,1,0,1,1,1,0,1,1,1,0,0,1,0},
                             {1,0,1,0,1,0,1,0,0,0,1,0,0,1,0},
                             {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                             {0,0,0,1,1,1,1,0,0,0,1,0,0,1,1},
                             {0,0,1,1,1,0,1,0,0,0,1,1,0,1,1},
                             {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                             {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                             {0,0,1,1,1,0,1,0,0,0,1,0,0,1,0},
                             {0,0,1,1,1,0,1,1,1,1,1,0,0,1,1}};
        PathfindingAStar example(mazeEx2, 1,1,10,0);
        example.findPath();
        }*/



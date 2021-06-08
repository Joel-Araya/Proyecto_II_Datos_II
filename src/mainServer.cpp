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

#include <iostream>
#include <cstdlib>
#include "Server.h"
#include "Client.h"
#include "src/Backtraking/Backtracking.h"
#include "src/PathfindingA/PathfindingAStar.h"

/**
 * @brief Contains the logic of the server algorithm
 *  
 * @param port of the server
 * @param number of memory space in bytes 
 */

int main(int argc, char *argv[]){

    int puerto = atoi(argv[1]);
	std::string opcion;

    Server *Servidor = new Server(puerto);
    Client *client = new Client();
    opcion = Servidor->Recibir();

    std::string text, revisar;

    while(true){
		//BP Game
		if(opcion == "1"){
			return 0;
		}
		//Puzzle game
		else if(opcion == "2"){
			return 1;
		}
        text = Servidor->Recibir();
        std::cout<<text<<std::endl;
        client->Enviar(textSalida);
        std::cin>>revisar;

    }

    return 0;
}

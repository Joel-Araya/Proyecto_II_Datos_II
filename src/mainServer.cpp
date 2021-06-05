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

/**
 * @brief Contains the logic of the server algorithm
 *  
 * @param port of the server
 * @param number of memory space in bytes 
 */

int main(int argc, char *argv[]){

    int puerto = atoi(argv[1]);


    Server *Servidor = new Server(puerto);
    Client *client = new Client();

    std::string text, revisar, textSalida, puntero;

    while(true){

    	textSalida = "[1,2,3,4,5,6]";
        text = Servidor->Recibir();
        std::cout<<text<<std::endl;
        client->Enviar(textSalida);
        std::cin>>revisar;

    }

    return 0;
}

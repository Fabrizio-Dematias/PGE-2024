#include <iostream>
#include "Personal.h"

using namespace std;

Personal::Personal(const string& nombre, int edad, const string& genero)
    : nombre(nombre), edad(edad), genero(genero) {}

//getters
string Personal::getNombre() const {
    return nombre;
}

int Personal::getEdad() const {
    return edad;
}

string Personal::getGenero() const {
    return genero;
}

//setters
void Personal::setNombre(const string& nombre) {
    this->nombre = nombre;
}

void Personal::setEdad(int edad) {
    this->edad = edad;
}

void Personal::setGenero(const string& genero) {
    this->genero = genero;
}

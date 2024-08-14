#ifndef PERSONA_H
#define PERSONA_H

#include <iostream>

using namespace std;

class Persona {
public:
    string nombre;
    int edad;
    string genero;

    Persona(string nombre, int edad, string genero);
    void mostrarDatos();
};

class Empleado : public Persona {
public:
    float salario;
    string cargo;

    Empleado(string nombre, int edad, string genero, float salario, string cargo);
    void mostrarDatos();
};

#endif 
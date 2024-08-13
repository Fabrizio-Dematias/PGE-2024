#include "persona.h"

Persona::Persona(string nombre, int edad, string genero) : nombre(nombre), edad(edad), genero(genero) {}

void Persona::mostrarDatos() {
    cout << "Nombre: " << nombre << endl;
    cout << "Edad: " << edad << endl;
    cout << "Genero: " << genero << endl;
}

Empleado::Empleado(string nombre, int edad, string genero, float salario, string cargo)
    : Persona(nombre, edad, genero), salario(salario), cargo(cargo) {}

void Empleado::mostrarDatos() {
    Persona::mostrarDatos();
    cout << "Salario: $" << salario << endl;
    cout << "Cargo: " << cargo << endl;
}

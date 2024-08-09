#include <iostream>
#include "Trabajador.h"

using namespace std;

int main() {
    Personal personal("Fabrizio Dematias", 24, "Masculino");

    Trabajador trabajador(personal, "Gerente", 5000.0);

    cout << "Nombre: " << trabajador.getPersonal().getNombre() << endl;
    cout << "Edad: " << trabajador.getPersonal().getEdad() << endl;
    cout << "Genero: " << trabajador.getPersonal().getGenero() << endl;
    cout << "Cargo: " << trabajador.getCargo() << endl;
    cout << "Salario Calculado: $" << trabajador.calcularSalario() << endl;

    return 0;
}

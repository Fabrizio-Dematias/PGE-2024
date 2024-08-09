#include <iostream>
#include "Persona.h"

using namespace std;

int main() {
		Persona p1("Fabrizio", 24, "Masculino");
	p1.mostrarDatos();

	cout << endl;

	Empleado e1("Maria", 50, "Femenino", 10000, "Gerente");
	e1.mostrarDatos();

	return 0;
}
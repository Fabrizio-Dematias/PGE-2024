#include <iostream>
#include "Vehiculo.h"

using namespace std;

Vehiculo::Vehiculo(string m, string mod, int a) : marca(m), modelo(mod), año(a) {}

void Vehiculo::mostrarInfo() {
    cout << "Marca: " << marca << endl;
    cout << "Modelo: " << modelo << endl;
    cout << "Fecha: " << año << endl;
}

Coche::Coche(string m, string mod, int a, int puertas)
    : Vehiculo(m, mod, a), numPuertas(puertas) {}

void Coche::mostrarInfo() {
    Vehiculo::mostrarInfo();
    cout << "Cantidad de puertas: " << numPuertas << endl;
}

Moto::Moto(string m, string mod, int a, int cc)
    : Vehiculo(m, mod, a), cilindrada(cc) {}

void Moto::mostrarInfo() {
    Vehiculo::mostrarInfo();
    cout << "Cilindrada: " << cilindrada << " cc" << endl;
}

int main() {

    Coche c("Fiat", "Palio", 2014, 5);
	Moto m("Guerrero", "GRF", 2014, 250);

	c.mostrarInfo();
	cout << endl;
	m.mostrarInfo();

	return 0;
}
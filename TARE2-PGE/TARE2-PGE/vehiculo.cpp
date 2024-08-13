#include "vehiculo.h"

Vehiculo::Vehiculo(string m, string mod, int a) : marca(m), modelo(mod), a�o(a) {}

void Vehiculo::mostrarInfo() {
    cout << "Marca: " << marca << endl;
    cout << "Modelo: " << modelo << endl;
    cout << "Fecha: " << a�o << endl;
}

Coche::Coche(string m, string mod, int a, int puertas) : Vehiculo(m, mod, a), numPuertas(puertas) {}

void Coche::mostrarInfo() {
    Vehiculo::mostrarInfo();
    cout << "Cantidad de puertas: " << numPuertas << endl;
}

Moto::Moto(string m, string mod, int a, int cc) : Vehiculo(m, mod, a), cilindrada(cc) {}

void Moto::mostrarInfo() {
    Vehiculo::mostrarInfo();
    cout << "Cilindrada: " << cilindrada << " cc" << endl;
}

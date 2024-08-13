#include "persona.h"
#include "personal.h"
#include "trabajador.h"
#include "vehiculo.h"

int main() {
    //clase persona y empleado
    Persona p1("Fabrizio", 24, "Masculino");
    p1.mostrarDatos();
    cout << endl;

    Empleado e1("Maria", 50, "Femenino", 10000, "Gerente");
    e1.mostrarDatos();
    cout << endl;

    //clase personal
    Personal personal("Carlos", 40, "Masculino");
    cout << "Nombre: " << personal.getNombre() << endl;
    cout << "Edad: " << personal.getEdad() << endl;
    cout << "Genero: " << personal.getGenero() << endl;
    cout << endl;

    //clase trabajador
    Trabajador trabajador(personal, "Supervisor", 3000);
    cout << "Salario del trabajador: $" << trabajador.calcularSalario() << endl;
    cout << endl;

    //clase vehiculo, coche y moto
    Coche coche("Fiat", "Palio", 2014, 5);
    Moto moto("Guerrero", "GRF", 2014, 250);

    coche.mostrarInfo();
    cout << endl;
    moto.mostrarInfo();

    return 0;
}

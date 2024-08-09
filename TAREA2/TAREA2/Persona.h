// EJERCICIO 1

#include <iostream>

using namespace std;

class Persona {

	public:
	string nombre;
	int edad;
	string genero;

	Persona(string nombre, int edad, string genero) {
		this->nombre = nombre;
		this->edad = edad;
		this->genero = genero;
	}

	void mostrarDatos() {
		cout << "Nombre: " << nombre << endl;
		cout << "Edad: " << edad << endl;
		cout << "Genero: " << genero << endl;
	}
};

class Empleado : public Persona {

	public:
	float salario;
	string cargo;

	Empleado(string nombre, int edad, string genero, float salario, string cargo) : Persona(nombre, edad, genero) {
		this->salario = salario;
		this->cargo = cargo;
	}

	void mostrarDatos() {
		Persona::mostrarDatos();
		cout << "Salario: $" << salario << endl;
		cout << "Cargo: " << cargo << endl;
	}
};




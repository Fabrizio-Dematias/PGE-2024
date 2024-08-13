#include "trabajador.h"

Trabajador::Trabajador(const Personal& personal, const string& cargo, double salarioBase)
    : personal(personal), cargo(cargo), salarioBase(salarioBase) {}

double Trabajador::calcularSalario() const {
    double salario = salarioBase;

    if (cargo == "Gerente") {
        salario *= 1.5;
    }
    else if (cargo == "Supervisor") {
        salario *= 1.2;
    }

    return salario;
}

string Trabajador::getCargo() const {
    return cargo;
}

void Trabajador::setCargo(const string& cargo) {
    this->cargo = cargo;
}

double Trabajador::getSalarioBase() const {
    return salarioBase;
}

void Trabajador::setSalarioBase(double salarioBase) {
    this->salarioBase = salarioBase;
}

Personal Trabajador::getPersonal() const {
    return personal;
}

void Trabajador::setPersonal(const Personal& personal) {
    this->personal = personal;
}

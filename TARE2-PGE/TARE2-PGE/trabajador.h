#ifndef TRABAJADOR_H
#define TRABAJADOR_H

#include <iostream>
#include "personal.h"

using namespace std;

class Trabajador {
private:
    Personal personal;
    string cargo;
    double salarioBase;

public:
    Trabajador(const Personal& personal, const string& cargo, double salarioBase);

    double calcularSalario() const;

    string getCargo() const;
    void setCargo(const string& cargo);

    double getSalarioBase() const;
    void setSalarioBase(double salarioBase);

    Personal getPersonal() const;
    void setPersonal(const Personal& personal);
};

#endif 

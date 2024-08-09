#include <iostream>
#include "Personal.h"

using namespace std;

class Trabajador {
private:
    Personal personal;
    string cargo;
    double salarioBase;

public:
    // Constructor
    Trabajador(const Personal& personal, const string& cargo, double salarioBase);

    double calcularSalario() const;

    //gettera y setters
    string getCargo() const;
    void setCargo(const string& cargo);

    double getSalarioBase() const;
    void setSalarioBase(double salarioBase);

    Personal getPersonal() const;
    void setPersonal(const Personal& personal);
};

#ifndef VEHICULO_H
#define VEHICULO_H

#include <iostream>

using namespace std;

class Vehiculo {
protected:
    string marca;
    string modelo;
    int año;

public:
    Vehiculo(string m, string mod, int a);
    virtual void mostrarInfo();
};

class Coche : public Vehiculo {
private:
    int numPuertas;

public:
    Coche(string m, string mod, int a, int puertas);
    void mostrarInfo() override;
};

class Moto : public Vehiculo {
private:
    int cilindrada;

public:
    Moto(string m, string mod, int a, int cc);
    void mostrarInfo() override;
};

#endif 

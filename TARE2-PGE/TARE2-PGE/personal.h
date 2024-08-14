#ifndef PERSONAL_H
#define PERSONAL_H

#include <iostream>

using namespace std;

class Personal {
private:
    string nombre;
    int edad;
    string genero;

public:
    Personal(const string& nombre, int edad, const string& genero);

    string getNombre() const;
    int getEdad() const;
    string getGenero() const;

    void setNombre(const string& nombre);
    void setEdad(int edad);
    void setGenero(const string& genero);
};

#endif 

#include <iostream>

using namespace std;

class Personal {
private:
    string nombre;
    int edad;
    string genero;

public:
    //constructor
    Personal(const string& nombre, int edad, const string& genero);

    //getters
    string getNombre() const;
    int getEdad() const;
    string getGenero() const;

    //setters
    void setNombre(const string& nombre);
    void setEdad(int edad);
    void setGenero(const string& genero);
};


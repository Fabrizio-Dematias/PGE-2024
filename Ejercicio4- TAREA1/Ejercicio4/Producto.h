#include <string>

using namespace std;

class Producto {
private:
    string nombre;
    int cantidadDisponible;
    double precio;

public:
    Producto(string nom, int cantidad, double precio);

    string getNombre() const;
    int getCantidadDisponible() const;
    double getPrecio() const;

    void setNombre(string nom);
    void setCantidadDisponible(int cantidad);
    void setPrecio(double precio);
};

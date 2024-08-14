#include "Producto.h"

Producto::Producto(string nom, int cantidad, double precio)
    : nombre(nom), cantidadDisponible(cantidad), precio(precio) {}

string Producto::getNombre() const {
    return nombre;
}

int Producto::getCantidadDisponible() const {
    return cantidadDisponible;
}

double Producto::getPrecio() const {
    return precio;
}

void Producto::setNombre(string nom) {
    nombre = nom;
}

void Producto::setCantidadDisponible(int cantidad) {
    cantidadDisponible = cantidad;
}

void Producto::setPrecio(double precio) {
    this->precio = precio;
}
#include "Inventario.h"
#include <iostream>

using namespace std;

void Inventario::agregarProducto(const Producto& producto) {
    productos.push_back(producto);
}

void Inventario::eliminarProducto(const string& nombre) {
    for (auto it = productos.begin(); it != productos.end(); ++it) {
        if (it->getNombre() == nombre) {
            productos.erase(it);
            break;
        }
    }
}

void Inventario::actualizarProducto(const string& nombre, int cantidad, double precio) {
    for (auto& producto : productos) {
        if (producto.getNombre() == nombre) {
            producto.setCantidadDisponible(cantidad);
            producto.setPrecio(precio);
            break;
        }
    }
}

void Inventario::mostrarInventario() const {
    for (const auto& producto : productos) {
        cout << "Nombre: " << producto.getNombre()
            << ", Cantidad: " << producto.getCantidadDisponible()
            << ", Precio: $" << producto.getPrecio() << endl;
    }
}

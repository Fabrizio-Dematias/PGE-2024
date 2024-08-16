#include "Inventario.h"
#include <iostream>
#include <vector>

using namespace std;

void Inventario::setCallback(void (*cb)(const string&)) {
    callback = cb;
}

void Inventario::agregarProducto(const Producto& producto) {
    productos.push_back(producto);
    if (callback) callback("Producto agregado: " + producto.getNombre());
}

void Inventario::eliminarProducto(const string& nombre) {
    for (auto it = productos.begin(); it != productos.end(); ++it) {
        if (it->getNombre() == nombre) {
            productos.erase(it);
            if (callback) callback("Producto eliminado: " + nombre);
            break;
        }
    }
}

// implementacion para la tarea 4
void Inventario::actualizarProducto(const string& nombre, int cantidad, double precio) {
    for (auto& producto : productos) {
        if (producto.getNombre() == nombre) {
            producto.setCantidadDisponible(cantidad);
            producto.setPrecio(precio);
            if (callback) callback("Producto actualizado: " + nombre);
            if (cantidad == 0 && callback) callback("Producto agotado: " + nombre);
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

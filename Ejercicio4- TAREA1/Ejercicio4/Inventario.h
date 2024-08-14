#include <vector>
#include "Producto.h"

using namespace std;

class Inventario {
private:
    vector<Producto> productos;
    void (*callback)(const string&);

public:
    void setCallback(void (*cb)(const string&));
    void agregarProducto(const Producto& producto);
    void eliminarProducto(const string& nombre);
    void actualizarProducto(const string& nombre, int cantidad, double precio);

    void mostrarInventario() const;
};

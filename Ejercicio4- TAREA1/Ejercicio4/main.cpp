#include <iostream>
#include "Inventario.h"

using namespace std;

void mostrarMenu() {
    cout << "\n Gestion de Inventario \n";
    cout << "1. Agregar producto\n";
    cout << "2. Eliminar producto\n";
    cout << "3. Actualizar producto\n";
    cout << "4. Mostrar inventario\n";
    cout << "5. Salir\n";
    cout << "Seleccione una opcion: ";
}
int main() {
    Inventario inventario;
    int opcion;
    string nombre;
    int cantidad;
    double precio;

    do {
        mostrarMenu();
        cin >> opcion;
        system("cls");

        switch (opcion) {
        case 1:
            cout << "Ingrese el nombre del producto: ";
            cin >> nombre;
            cout << "Ingrese la cantidad disponible: ";
            cin >> cantidad;
            cout << "Ingrese el precio: ";
            cin >> precio;
            inventario.agregarProducto(Producto(nombre, cantidad, precio));
            cout << "Producto agregado.\n";
            break;
            system("cls");

        case 2:
            cout << "Ingrese el nombre del producto a eliminar: ";
            cin >> nombre;
            inventario.eliminarProducto(nombre);
            cout << "Producto eliminado.\n";
            break;
            system("cls");

        case 3:
            cout << "Ingrese el nombre del producto a actualizar: ";
            cin >> nombre;
            cout << "Ingrese la nueva cantidad: ";
            cin >> cantidad;
            cout << "Ingrese el nuevo precio: ";
            cin >> precio;
            inventario.actualizarProducto(nombre, cantidad, precio);
            cout << "Producto actualizado.\n";
            break;
            system("cls");

        case 4:
            inventario.mostrarInventario();
            break;

        case 5:
            cout << "Saliendo...";
            break;

        default:
            cout << "Opcion no valida. Intente nuevamente.\n";
        }
    } while (opcion != 5);

    return 0;
}

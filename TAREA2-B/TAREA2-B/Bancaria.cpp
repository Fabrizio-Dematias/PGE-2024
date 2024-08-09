#include <iostream>
#include "Bancaria.h"

using namespace std;

int main() {
    CuentaCorriente cuentaCorriente(100, 1234);
    CuentaAhorro cuentaAhorro(100, 5678);

    cout << "Saldo cuenta corriente: " << cuentaCorriente.getSaldo() << endl;
    cout << "Saldo cuenta ahorro: " << cuentaAhorro.getSaldo() << endl;

    cout << endl;

    cuentaCorriente.depositar(100);
    cuentaAhorro.depositar(100);

    cout << "Saldo cuenta corriente: " << cuentaCorriente.getSaldo() << endl;
    cout << "Saldo cuenta ahorro: " << cuentaAhorro.getSaldo() << endl;

    cout << endl;

    cuentaCorriente.cobrarComision();
    cuentaAhorro.calcularIntereses();

    cout << "Saldo cuenta corriente: " << cuentaCorriente.getSaldo() << endl;
    cout << "Saldo cuenta ahorro: " << cuentaAhorro.getSaldo() << endl;

    cout << endl;

    cuentaCorriente.retirar(50);
    cuentaAhorro.retirar(20);

    cout << "Saldo final cuenta corriente: " << cuentaCorriente.getSaldo() << endl;
    cout << "Saldo final cuenta ahorro: " << cuentaAhorro.getSaldo() << endl;

    return 0;
}

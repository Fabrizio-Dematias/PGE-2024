using namespace std;

class CuentaBancaria {
protected:
    int saldo;
    int numeroCuenta;

public:
    CuentaBancaria(int saldo, int numeroCuenta) {
        this->saldo = saldo;
        this->numeroCuenta = numeroCuenta;
    }

    int getSaldo() const {
        return saldo;
    }

    int getNumeroCuenta() const {
        return numeroCuenta;
    }

    void setSaldo(int saldo) {
        this->saldo = saldo;
    }

    void setNumeroCuenta(int numeroCuenta) {
        this->numeroCuenta = numeroCuenta;
    }

    virtual void depositar(int cantidad) {
        if (cantidad > 0) {
            saldo += cantidad;
        }
        else {
            cout << "Cantidad inválida para depositar.\n";
        }
    }

    virtual void retirar(int cantidad) {
        if (cantidad > 0 && cantidad <= saldo) {
            saldo -= cantidad;
        }
        else {
            cout << "Fondos insuficientes o cantidad inválida.\n";
        }
    }

    virtual ~CuentaBancaria() {}
};

class CuentaCorriente : public CuentaBancaria {
public:
    CuentaCorriente(int saldo, int numeroCuenta) : CuentaBancaria(saldo, numeroCuenta) {
    }

    void cobrarComision() {
        if (saldo >= 10) {
            saldo -= 10;
        }
        else {
            cout << "Saldo insuficiente para cobrar la comision.\n";
        }
    }
};

class CuentaAhorro : public CuentaBancaria {
public:
    CuentaAhorro(int saldo, int numeroCuenta) : CuentaBancaria(saldo, numeroCuenta) {
    }

    void calcularIntereses() {
        saldo += saldo * 0.1;
    }
};

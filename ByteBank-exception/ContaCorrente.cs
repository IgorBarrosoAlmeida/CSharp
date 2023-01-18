﻿using ByteBank_exception.Exceptions;

namespace ByteBank_exception {
    public class ContaCorrente {
        // Atributos e propriedades
        public Cliente Titular { get; set; }
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        public int Agencia {
            get {
                return _agencia;
            }
            private set {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }
        private double _saldo;
        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        // Construtores
        public ContaCorrente(int agencia, int numero) {
            if(numero <= 0 && agencia <= 0) {
                throw new ArgumentException("Os argumentos agencia e numero devem ser maiores que 0");
            }
            else if(agencia <= 0) {
                throw new ArgumentException("O argumento agencia deve ser maior que 0", nameof(agencia));
            } else if(numero <= 0) {
                throw new ArgumentException("O argumento numero deve ser maior que 0", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            
            TotalDeContasCriadas++;
            TaxaOperacao = 30 /  TotalDeContasCriadas;
        }

        // Métodos
        public void Sacar(double valor) {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente", this._saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor) {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}

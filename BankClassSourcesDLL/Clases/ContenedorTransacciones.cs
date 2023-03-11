﻿using BankClassSourcesDLL.Contratos;

namespace BankClassSourcesDLL.Clases
{
    public class ContenedorTransacciones : IContenedorTransacciones
    {
        private List<Transaccion> listaTransaccion;

        public ContenedorTransacciones()
        {
            listaTransaccion = new List<Transaccion>();
        }

        public void AddTransc(Transaccion transaccion)
        {
            listaTransaccion.Add(transaccion);
        }
        
        public List<Transaccion> GetTransacciones()
        {
            return listaTransaccion;
        }

        public void Clear()
        {
            listaTransaccion.Clear();
        }

    }
}
﻿using System;
using System.Collections.Generic;

namespace Facade.BLL
{
    interface ICadastro
    {
        void Inserir(object obj);
        void Alterar(int id);
        void Excluir(int id);
        object Consultar(int id);
        List<Object> Listar();

    }
}

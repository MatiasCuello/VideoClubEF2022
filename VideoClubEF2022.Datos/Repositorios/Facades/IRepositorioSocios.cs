﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    interface IRepositorioSocios
    {
        List<Socio> GetLista(Provincia provincia,Localidad localidad);
        void Guardar(Socio socio);
        void Borrar(Socio socio);
        bool Existe(Socio socio);
        bool EstaRelacionado(Socio socio);

    }
}

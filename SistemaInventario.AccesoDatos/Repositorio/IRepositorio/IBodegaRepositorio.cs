﻿using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{//esta interfaz va a aherde de la generica
    public interface IBodegaRepositorio: IRepositorio<Bodega>
    {
        void Actualizar(Bodega bodega);

    }
}

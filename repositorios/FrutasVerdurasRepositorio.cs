﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandaleFruta.helper;
using System.Data;
using MandaleFruta.Modelos;


namespace MandaleFruta.repositorios
{
    public class FrutasVerdurasRepositorio
    {
        private acceso_BD _BD;

        public FrutasVerdurasRepositorio()
        {
            _BD = new acceso_BD();
        }
        public DataTable obtenerFrutasVerdurasDT()
        {
            string sqltxt = "SELECT * FROM frutaVerdura";
            return _BD.consulta(sqltxt);

        }
        
        
        public bool Guardar(FrutaVerdura frutaVerdura)
        {
            string sqltxt = $"INSERT [dbo].[FrutaVerdura] ([nombre],[id_Frutaverdura],[id_tipo]) " +
                $"VALUES ('{frutaVerdura.id_FrutaVerdura},{frutaVerdura.Nombre},{frutaVerdura.id_Tipo}')";
            return _BD.EjecutarSQL(sqltxt);
        }
    }
}

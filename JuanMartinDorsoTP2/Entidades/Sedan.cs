using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Enumerado"
        /// <summary>
        /// Enumerador que define el tipo de Sedan a traves de la cant. de puertas
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }
        #endregion

        #region "Atributo"
        private ETipo tipo;
        #endregion

        #region "Constrcutores"
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del sedan</param>
        /// <param name="chasis">Chasis del sedan</param>
        /// <param name="color">Color del sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
            
        }

        /// <summary>
        /// Constructor que utiliza el de la base con posibilidad de inicializar el tipo
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">Chasis del Sedan</param>
        /// <param name="color">Color del Sedan</param>
        /// <param name="tipo">Tipo (cant puertas) del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region "Propiedad"
        /// <summary>
        /// Propiedad de solo lectura, los Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region "Metodo"
        /// <summary>
        /// Metodo que sobreescribe al de la base, mostrando los datos del sedan y agregando el tamaño y tipo
        /// </summary>
        /// <returns>los datos del sedan en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}

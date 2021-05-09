using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Constructor"
        /// <summary>
        /// Constructor de Ciclomotor por 3 parametros
        /// </summary>
        /// <param name="chasis">chasis del ciclomotor</param>
        /// <param name="marca">marca del ciclomotor</param>
        /// <param name="color">color del ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base (chasis, marca, color)
        {
        }
        #endregion

        #region "Propiedad"
        /// <summary>
        /// Propiedad de solo lectura, los Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodo"
        /// <summary>
        /// Metodo que sobreescribe al de la base, mostrando los datos del ciclomotor y agregando el tamaño
        /// </summary>
        /// <returns>los datos del ciclomotor en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : " + this.Tamanio);
            //Se comenta para que quede exactamente los mismos saltos de linea al ejemplo "Funcional"
            //auxRetorno.AppendLine(""); 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}

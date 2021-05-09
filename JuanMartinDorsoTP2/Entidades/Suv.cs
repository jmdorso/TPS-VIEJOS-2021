using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructor"
        /// <summary>
        /// Constructor de un SUV, utilizando el constructor de la clase base Vehiculo
        /// </summary>
        /// <param name="marca">Marca del SUV</param>
        /// <param name="chasis">Chasis del SUV</param>
        /// <param name="color">Color del SUV</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis,marca,color)
        {
        }
        #endregion

        #region "Propiedad"
        /// <summary>
        /// Propiedad de solo lectura, los SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region "Metodo"
        /// <summary>
        /// Metodo que sobreescribe al de la base, mostrando los datos del suv y agregando el tamaño
        /// </summary>
        /// <returns>los datos del SUV en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}"); 
            //Se comenta para que quede exactamente los mismos saltos de linea al ejemplo "Funcional"
            //auxRetorno.AppendLine(""); 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}

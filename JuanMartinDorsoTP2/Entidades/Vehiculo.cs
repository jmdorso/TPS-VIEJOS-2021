using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region "Enumerados"
        /// <summary>
        /// Enumerado que define la marca del vehiculo
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumerador que define el tamaño del vehiculo
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion

        #region "Atributos"
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor de Vehiculos por 3 parametros
        /// </summary>
        /// <param name="chasis">chasis del vehiculo</param>
        /// <param name="marca">marca del vehiculo</param>
        /// <param name="color">color del vehiculo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region "Propiedad"
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}
        #endregion

        #region "Metodo, sobrecarga & operadores"
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Sobrecarga explicita que permite mostrar los datos del vehiculo
        /// </summary>
        /// <param name="vehiculo">Vehiculo a mostrar</param>
        public static explicit operator string(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", vehiculo.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", vehiculo.marca);
            sb.AppendFormat("COLOR : {0}\r\n", vehiculo.color);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="vehiculoUno">Primer vehiculo a comparar</param>
        /// <param name="vehiculoDos">Segundo vehiculo a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return (vehiculoUno.chasis == vehiculoDos.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="vehiculoUno">Primer vehiculo a comparar</param>
        /// <param name="vehiculoDos">Segundo vehiculo a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return !(vehiculoUno == vehiculoDos);
        }
        #endregion
    }
}

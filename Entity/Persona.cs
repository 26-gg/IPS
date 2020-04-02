using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Identificacion  { get; set; }
        public string Nombre{ get; set; }
        public string Sexo{ get; set; }
        public int Edad { get; set; }
        public int Pulsaciones { get; set; }

        public Persona()
        {

        }
        public Persona (string pIdentificacion, string pNombre, string pSexo,int pEdad )
        {
            Identificacion=pIdentificacion;
            Nombre = pNombre;
            Sexo = pSexo;
            Edad = pEdad;
        }
        public void CalcularPulsaciones()
        {
            if (Sexo == "f")
            {
                Pulsaciones = (220 - Edad) / 10;

            }
            else if (Sexo == "m")
            {
                Pulsaciones = (210 - Edad) / 10;
            }
        }


           public override string ToString()
        {
            return $"las pulsaciones de la Identificacion {Identificacion} son {Pulsaciones} ";

        }







    }



    }


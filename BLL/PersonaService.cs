using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PersonaService
    {
        PersonaRepository PersonaRepositorio   = new PersonaRepository();
        public String Guardar(Persona persona)
        {
            if (PersonaRepositorio.BuscarIdentificacion(persona.Identificacion)==null)
            {
                PersonaRepositorio.Guardar(persona);
                return $"se guardo la persona con la identificacion {persona.Identificacion}";
            }
            return $"la persona con identificacion {persona.Identificacion} no se guardo";
    

        }

        public String Eliminar(Persona persona)
        {
            if (persona== null)
            {
                return $"la persona {persona.Identificacion} no se encuentra registrada ";
            }
            if (PersonaRepositorio.BuscarIdentificacion(persona.Identificacion)==null)
            {
                return $"la identificacion {persona.Identificacion}la persona no se encuentra registrada ";
            }
            PersonaRepositorio.Eliminar(persona);
            return $"la identificacion {persona.Identificacion}se elimino correctamente";
        }

        public List<Persona> Consultar()
        {
            return PersonaRepositorio.Consultar();
        }

        public Persona CalcularPulsaciones(Persona persona) 
        {
            persona.CalcularPulsaciones();
            return persona;
        }
        public Persona Buscar(string id)

        {
            return PersonaRepositorio.BuscarIdentificacion(id);
        }


    }
}

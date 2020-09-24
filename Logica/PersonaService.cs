using System;

namespace Logica
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
        public Persona Buscar(string id)

        {
            return PersonaRepositorio.BuscarIdentificacion(id);
        }


            public class GuardarPersonaResponse 
    {
        public GuardarPersonaResponse(Persona persona)
        {
            Error = false;
            Persona = persona;
        }
        public GuardarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }

    public Persona BuscarPorIdentificacion(string identificacion)

        {
            return PersonaRepositorio.BuscarPorIdentificacion(id);
        }

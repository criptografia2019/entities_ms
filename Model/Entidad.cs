using System;
using System.ComponentModel.DataAnnotations;

namespace EntidadesApi.Model
{

	public class Entidad
	{
        [Key]
		public int IdEntidad 
		{
			get;
			set;
		}

		public string TipoEntidad
		{
			get;
			set;
		}

		public string Descripcion
		{
			get;
			set;
		}

        public Double Calificacion{
            get;
            set;

        }

        public string Direccion{
            get;
            set;
        }

        public string Coordenadas{
            get;
            set;
        }

        public string Zona{
            get;
            set;
        }

	}

}

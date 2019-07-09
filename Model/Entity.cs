using System;
using System.ComponentModel.DataAnnotations;

namespace EntidadesApi.Model
{

	public class Entity
	{
        [Key]
		public int idEntity 
		{
			get;
			set;
		}

		public string TypeEntity
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}


        public string Address{
            get;
            set;
        }

        public string Coordinates{
            get;
            set;
        }

        public string Zone{
            get;
            set;
        }

		public string Name
		{

			get;
			set;

		}

	}

}

using System;
using System.ComponentModel.DataAnnotations;



namespace EntidadesApi.Model
{

	public class Score
	{
        [Key]
		public int idScore
		{
			get;
			set;
		}

		public double ScoreEntity
		{
			get;
			set;
		}

		public string Commentary
		{
			get;
			set;
		}


        public int Entity_idEntity{
            get;
            set;
        }

   

	}

}

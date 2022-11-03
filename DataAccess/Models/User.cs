using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
	public class User
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid UserId { get; set; }

		public int RoleId { get; set; }


		public virtual Role Role { get; set; }

	}
}

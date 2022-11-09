using DataAccess.Abstract;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
	public class RoleRepository : IRepository<Role>
	{
		private readonly EmployeeManagerContext _context;
		
		public RoleRepository()
		{
			this._context = new EmployeeManagerContext();
		}

		public void Add(Role entity)
		{
			_context.Roles.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Role entity)
		{
            _context.Roles.(
            _context.SaveChanges();
        }

		public void Edit(Role entity)
		{
			throw new NotImplementedException();
		}

		public Role GetById(dynamic id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Role> List()
		{
			throw new NotImplementedException();
		}
	}
}

using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Fiap.Apostila08.MVC.Web.Contexts;

namespace Fiap.Apostila08.MVC.Web.DAL
{
    public class MedicoRepository : IMedicoRepository
    {
        private AgendaContext _context;

        public MedicoRepository(AgendaContext context) {

            this._context = context;
        }

        public void Delete(int id)
        {
            var consulta = _context.Consultas.Find(id);
            _context.Consultas.Remove(consulta);
        }

        public Medico FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Medico consulta)
        {
            throw new NotImplementedException();
        }

        public List<Medico> List()
        {
            throw new NotImplementedException();
        }

        public List<Medico> SearchFor(Expression<Func<Medico, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Medico consulta)
        {
            throw new NotImplementedException();
        }
    }
}

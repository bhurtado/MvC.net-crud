using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.DAL
{
    public interface IMedicoRepository
    {
        void Insert(Medico consulta);
        void Update(Medico consulta);
        void Delete(int id);
        Medico FindById(int id);
        List<Medico> List();
        List<Medico> SearchFor(Expression<Func<Medico, bool>> filtro);
    }
}

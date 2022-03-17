using ProvaSuficiencia.Database;
using ProvaSuficiencia.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProvaSuficiencia.Repositories
{
    public class AlunosRepository
    {
        private readonly DatabaseContext _databaseContext;

        public AlunosRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _databaseContext.Alunos.ToList();
        }

        public void Insert(Aluno aluno)
        {
            _databaseContext.Alunos.Add(aluno);
            _databaseContext.SaveChanges();
        }
    }
}

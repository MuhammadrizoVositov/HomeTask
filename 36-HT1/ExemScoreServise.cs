using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_HT1
{
    public interface ExemScoreServise
    {
        ExemScore GetById(int id);
        IEnumerable<ExemScore> GetAll();
        void Add(ExemScore score);
        void Update(ExemScore score);
        void Delete(int id);

    }
}

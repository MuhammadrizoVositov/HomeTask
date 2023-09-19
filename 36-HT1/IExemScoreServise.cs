using _36_HT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _36_HT1
{
    public class IExemScoreServise : ExemScoreServise
    {
        private List<ExemScore> _exemScores;
        public void Add(ExemScore score)
        {
           _exemScores.Add(score);
        }

        public void Delete(int id)
        {
            _exemScores.Remove(GetById(id));
        }

        public IEnumerable<ExemScore> GetAll()
        {
            return _exemScores;
        }

        public ExemScore GetById(int id)
        {
            return _exemScores.FirstOrDefault(a => a.Id == id);
        }

        public void Update(ExemScore score)
        {
            var update = _exemScores.FirstOrDefault(x => x.Id==score.Id);
        }
    }
}



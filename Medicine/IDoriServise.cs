using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine
{
    public interface  IDoriServise
    {
        Dori Create(Dori dori);
        Dori GetBYId(int id);
        IEnumerable<Dori> GetAll();
        Dori Update(Dori dori);
        bool Delete(int Id);
    }
}

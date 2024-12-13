using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public interface IToolTypeRepository
    {
        IList<ToolType> GetAll(); 
        ToolType GetById(int id);
        ToolType Add(ToolType toolType);
        ToolType Update(ToolType toolType);
        int Delete(int id);
    }
}

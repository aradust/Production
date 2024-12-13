using System.Collections.Generic;

namespace Production.Usecase
{
    public class ToolTypeUsecase
    {
        private readonly IToolTypeRepository _Repository;

        public ToolTypeUsecase(IToolTypeRepository repository)
        {
            _Repository = repository;
        }
        public IList<ToolType> GetAll()
        { 
            return _Repository.GetAll();
        }
        public ToolType Add(ToolType toolType)
        {
            return _Repository.Add(toolType);
        }
        public int Delete(int id)
        {
            return _Repository.Delete(id);
        }
    }
}

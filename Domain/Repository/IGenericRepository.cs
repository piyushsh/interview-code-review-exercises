namespace Domain.Repository
{
    public interface IGenericRepository<in TModel> 
        where TModel : class
    {
        public void Add(TModel model);
        public void Update(TModel model);  
        public void Delete(TModel model);
    }
}

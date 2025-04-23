namespace Repository
{
    public class InMemoryDb<TModel>
        where TModel : class
    {
        public List<TModel> DataStore { get; set; }

        public InMemoryDb() { 
            DataStore = new List<TModel>();
        }

        public void Add(TModel model)
        {
            DataStore.Add(model);
        }

        public void Delete(TModel model) { 
            DataStore.Remove(model);
        }

        public void Update(TModel model)
        {
            Delete(model);
            Add(model);
        }
    }
}

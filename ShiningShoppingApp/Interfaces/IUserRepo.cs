namespace ShiningShoppingApp.Interfaces
{
    public interface IUserRepo<K,T>
    {
        public List<T> GetAll();
        public T Get(K key);
        public T FindByEmailAndPassword(string email, string password);
        public T Add(T item);
        public T Delete(K key);
        public T Update(T item);
    }
}

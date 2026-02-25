namespace MyBlog.BusinessLayer.Abstract;

public interface IGenericService<T> where T:class
{
    List<T> TGetAll();
    T TGet(int id);
    void TAdd(T entity);
    void TUpdate(T entity);
    void TDelete(T entity);
}
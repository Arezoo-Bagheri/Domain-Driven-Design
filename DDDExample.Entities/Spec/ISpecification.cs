namespace DDDExample.Entities.Spec
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }

}

using System.Linq.Expressions;

namespace Avito.Infrastructure;

/// <summary>
/// Базовый (Тупой, почти как я) Репозиторий
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Возвращает все элементы сущности <see cref="TEntity"/>.
    /// </summary>
    /// <returns>Все элементы сущности <see cref="TEntity"/>.</returns>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Возвращает все элементы сущности <see cref="TEntity"/> по фильтру.
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <returns>Все элементы сущности <see cref="TEntity"/> по фильтру.</returns>
    IQueryable<TEntity> GetAllFiletered(Expression<Func<TEntity, bool>> filter);

    /// <summary>
    /// Возвращает элемент <see cref="TEntity"/> по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор <see cref="TEntity"/>.</param>
    /// <returns><see cref="TEntity"/>.</returns>
    Task<TEntity> GetByIdAsync(Guid id);

    /// <summary>
    /// Добавляет элемент <see cref="TEntity"/>.
    /// </summary>
    /// <param name="model">Новая сущность <see cref="TEntity"/>.</param>
    Task AddAsync(TEntity model);

    /// <summary>
    /// Обновляет элемент <see cref="TEntity"/>.
    /// </summary>
    /// <param name="model">Существующая сущность <see cref="TEntity"/>.</param>
    Task UpdateAsync(TEntity model);

    /// <summary>
    /// Удаляет элемент <see cref="TEntity"/>.
    /// </summary>
    /// <param name="model">Существующая сущность <see cref="TEntity"/>.</param>
    Task DeleteAsync(TEntity model);
}
using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IProductRepository"/> для выполнения операций с продуктами.
    /// </summary>
    internal class MaterialUsecase
    {
        private readonly IMaterialRepository _materialRepository;

        /// <summary>
        /// Конструктор класса <see cref="ProductionUsecase"/>.
        /// </summary>
        /// <param name="productRepository">Репозиторий для работы с продуктами.</param>
        public MaterialUsecase(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository ?? throw new ArgumentNullException(nameof(materialRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public IEnumerable<Material> GetAllMaterial()
        {
            return _materialRepository.GetAll();
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public Material GetMaterialById(int id)
        {
            return _materialRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public Material AddMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material), "Продукт не может быть null.");
            }

            return _materialRepository.Add(material);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="product">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public Material UpdateMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material), "Продукт не может быть null.");
            }

            return _materialRepository.Update(material);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteMaterial(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(Product product.Id), "Продукт не может быть null.");
             }*/

            return _materialRepository.Delete(Id);
        }
    }
}

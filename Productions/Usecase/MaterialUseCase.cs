using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с материалами.
    /// Использует репозиторий <see cref="IMaterialRepository"/> для выполнения операций с материалами.
    /// </summary>
    internal class MaterialUsecase
    {
        protected readonly IMaterialRepository _materialRepository;

        /// <summary>
        /// Конструктор класса <see cref="MaterialUsecase"/>.
        /// </summary>
        /// <param name="materialRepository">Репозиторий для работы с материалами.</param>
        public MaterialUsecase(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository ?? throw new ArgumentNullException(nameof(materialRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все материалы.
        /// </summary>
        /// <returns>Список всех материалов.</returns>
        public virtual BindingList<Material> GetAllMaterial()
        {
            return new BindingList<Material>(_materialRepository.GetAll().ToList());
        }

        /// <summary>
        /// Получает материал по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор материала.</param>
        /// <returns>Материал с указанным идентификатором, или <c>null</c>, если материал не найден.</returns>
        public virtual Material GetMaterialById(int id)
        {
            return _materialRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый материал.
        /// </summary>
        /// <param name="material">Материал, который нужно добавить.</param>
        /// <returns>Добавленный материал с обновленными данными.</returns>
        public virtual Material AddMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material), "Материал не может быть null.");
            }

            return _materialRepository.Add(material);
        }

        /// <summary>
        /// Обновляет данные существующего материала.
        /// </summary>
        /// <param name="material">Обновленные данные материала.</param>
        /// <returns>Обновленный материал.</returns>
        public virtual Material UpdateMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material), "Материал не может быть null.");
            }

            return _materialRepository.Update(material);
        }

        /// <summary>
        /// Удаляет материал.
        /// </summary>
        /// <param name="Id">Идентификатор материала, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного материала или <c>0</c>, если удаление не удалось.</returns>
        public virtual ulong DeleteMaterial(int Id)
        {
            return _materialRepository.Delete(Id);
        }
    }
}

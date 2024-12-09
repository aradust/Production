using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryMaterialRepository : IMaterialRepository
    {
        private readonly List<Material> _materials;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryMaterialRepository()
        {
            _materials = new List<Material>();
        }

        // Получить все продукты
        public IEnumerable<Material> GetAll()
        {
            return _materials;
        }

        // Получить продукт по ID
        public Material GetByID(int id)
        {
            return _materials.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        public Material Add(Material material)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (material.Id == 0)
            {
                material.Id = _materials.Any() ? _materials.Max(p => p.Id) + 1 : 1;
            }
            _materials.Add(material);
            return material;
        }

        // Обновить существующий продукт
        public Material Update(Material material)
        {
            var existingMaterial = GetByID(material.Id);
            if (existingMaterial == null)
            {
                throw new InvalidOperationException($"Product with ID {material.Id} not found.");
            }

            //Delete(existingProduct);
            Add(material);

            return existingMaterial;
        }

        // Удалить продукт по объекту
        public ulong Delete(int id)
        {
            var existingMaterial = _materials.FirstOrDefault(p => p.Id == id);
            if (existingMaterial == null)
            {
                return 0; // Продукт не найден
            }

            _materials.Remove(existingMaterial);
            return (ulong)id;
        }
    }
}

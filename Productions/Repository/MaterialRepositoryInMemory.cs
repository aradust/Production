using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryMaterialRepository : IMaterialRepository
    {
        protected List<Material> _materials;

        // Конструктор, который инициализирует пустой список материалов
        public InMemoryMaterialRepository()
        {
            _materials = new List<Material>();
        }

        // Получить все материалы
        virtual public IEnumerable<Material> GetAll()
        {
            return _materials;
        }

        // Получить материал по ID
        virtual public Material GetByID(int id)
        {
            return _materials.FirstOrDefault(m => m.Id == id);
        }

        // Добавить новый материал
        virtual public Material Add(Material material)
        {
            // Присваиваем новый ID материалу, если он не задан
            if (material.Id == 0)
            {
                material.Id = _materials.Any() ? _materials.Max(m => m.Id) + 1 : 1;
            }
            _materials.Add(material);
            return material;
        }

        // Обновить существующий материал
        virtual public Material Update(Material material)
        {
            var existingMaterial = GetByID(material.Id);
            if (existingMaterial == null)
            {
                throw new InvalidOperationException($"Material with ID {material.Id} not found.");
            }

            Delete(existingMaterial.Id);
            Add(material);

            return existingMaterial;
        }

        // Удалить материал по ID
        virtual public ulong Delete(int id)
        {
            var existingMaterial = _materials.FirstOrDefault(m => m.Id == id);
            if (existingMaterial == null)
            {
                return 0; // Материал не найден
            }

            _materials.Remove(existingMaterial);
            return (ulong)id;
        }
    }
}

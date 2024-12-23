using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Production
{
    /// <summary>
    /// Класс-наследник MaterialUsecase с логированием операций.
    /// </summary>
    internal class MaterialUsecaseWithLogging : MaterialUsecase
    {
        private const string LogFilePath = "log.txt";

        public MaterialUsecaseWithLogging(IMaterialRepository materialRepository)
            : base(materialRepository)
        {
        }

        private void Log(string message)
        {
            File.AppendAllText(LogFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        public new BindingList<Material> GetAllMaterial()
        {
            Log("Вызов метода GetAllMaterial.");
            var result = base.GetAllMaterial();
            Log($"Получено {result.Count} материалов.");
            return result;
        }

        public new Material GetMaterialById(int id)
        {
            Log($"Вызов метода GetMaterialById с id={id}.");
            var material = base.GetMaterialById(id);
            if (material == null)
            {
                Log($"Материал с id={id} не найден.");
            }
            else
            {
                Log($"Материал с id={id} успешно получен.");
            }
            return material;
        }

        public new Material AddMaterial(Material material)
        {
            Log($"Вызов метода AddMaterial. Добавляемый материал: {material?.ToString() ?? "null"}.");
            var result = base.AddMaterial(material);
            Log($"Материал успешно добавлен. Id нового материала: {result.Id}.");
            return result;
        }

        public new Material UpdateMaterial(Material material)
        {
            Log($"Вызов метода UpdateMaterial. Обновляемый материал: {material?.ToString() ?? "null"}.");
            var result = base.UpdateMaterial(material);
            Log($"Материал с id={result.Id} успешно обновлен.");
            return result;
        }

        public new ulong DeleteMaterial(int id)
        {
            Log($"Вызов метода DeleteMaterial с id={id}.");
            var result = base.DeleteMaterial(id);
            if (result > 0)
            {
                Log($"Материал с id={id} успешно удален.");
            }
            else
            {
                Log($"Удаление материала с id={id} не удалось.");
            }
            return result;
        }
    }
}

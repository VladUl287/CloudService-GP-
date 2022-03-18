using System;

namespace Test.Models
{
    public class StorageFile
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public long Compress { get; set; }
        public string Extension { get; set; }
        public string Modified { get; set; }

        public override string ToString()
        {
            var compress = Compress > 0 ? $"Сжатие: {Compress} КБ.\n" : string.Empty;
            return $"Наименование: {Name}\nРазмер: {Length} Байт.\n{compress}" +
                    $"Расширение: {Extension}\nДата последнего изменения: {DateTime.Parse(Modified)}";
        }
    }
}
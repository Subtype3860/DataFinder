using DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataFinder.BLL
{
    internal class FileService
    {
        public FileRepository fileRepository { get; }
        public FileService(FileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }
        public IEnumerable<File> GetAllFiles()
        {
            return this.fileRepository.GetFilesByDirectory().ToList()
                .Select(s => new File(s));
        }
        public File GetFileByFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new BusinessRuleException("Введите корректное значение!");
            var fileEntity = fileRepository.GetFileByFileName(fileName);
            if(fileEntity is null)
                throw new BusinessRuleException($"Файл {fileName} не обнаружен!");
            return new File(fileEntity);
        }
    }
}

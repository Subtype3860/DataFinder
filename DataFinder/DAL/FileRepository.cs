﻿using System;

namespace DataFinder.DAL
{
    internal class FileRepository
    {
        private IEnumerable<FileEntity> files { get; }
        public FileRepository()
        {
            files = new List<FileEntity>
            {
                new FileEntity(Guid.NewGuid(), "Реферат.docx", "C:/Desktop/Docs/Реферат.docx"),
                new FileEntity(Guid.NewGuid(), "Отчет.docx", "C:/Desktop/Docs/Отчет.docx"),
                new FileEntity(Guid.NewGuid(), "Книга1.xls", "C:/Desktop/Docs/Книга1.xls"),
                new FileEntity(Guid.NewGuid(), "Фото на документы.jpeg", "C:/Desktop/Docs/Фото на документы.jpeg"),
                new FileEntity(Guid.NewGuid(), "Ярлык.lnk", "C:/Desktop/Docs/Ярлык.lnk"),
            };
        }
        public IEnumerable<FileEntity> GetFilesByDirectory() 
        {
            return files;
        }
        public FileEntity GetFileByFileName(string fileName)
        {
            return files.FirstOrDefault(f => f.Name == fileName)!;
        }
    }
}
using System;
using DataFinder.DAL;

namespace DataFinder.BLL
{
    public class File
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
        public File(FileEntity fileEntity) 
        {
            Id = fileEntity.Id;
            Name = fileEntity.Name;
            Path = fileEntity.Path;
        }
    }
}

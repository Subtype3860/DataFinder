﻿using System;

namespace DataFinder.DAL
{
    internal class FileEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
        public FileEntity(Guid id, string name, string path) 
        { 
            Id = id;
            Name = name;
            Path = path;
        }
    }
}
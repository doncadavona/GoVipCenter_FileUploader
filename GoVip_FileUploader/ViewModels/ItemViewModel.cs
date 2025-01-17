﻿using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace GoVip_FileUploader.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class ItemViewModel
    {
        // constructor
        public ItemViewModel()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Filepath { get; set; }
        public IFormFile File { get; set; }
        public string UpdatedBy { get; set; }
        public string UploadedBy { get; set; }
        [JsonIgnore]
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

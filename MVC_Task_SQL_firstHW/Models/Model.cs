﻿namespace MVC_Task_SQL_firstHW.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }

}

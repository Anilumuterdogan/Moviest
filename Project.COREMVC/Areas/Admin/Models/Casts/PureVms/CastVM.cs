﻿namespace Project.COREMVC.Areas.Admin.Models.Casts.PureVms
{
    public class CastVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? VideoPath { get; set; }
    }
}

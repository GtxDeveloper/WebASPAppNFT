﻿namespace WebASPAppNFT.Entities
{
    public class Category
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string ImgSrc { get; set; }

        public string Slug { get; set; }

        public int Order {  get; set; }
    }
}

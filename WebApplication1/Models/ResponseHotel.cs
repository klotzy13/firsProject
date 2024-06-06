﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class ResponseHotel
    {
        public ResponseHotel(Hotel hotel) 
        {
            Id= hotel.id;
            Name= hotel.Name;
            CountOfStars= hotel.CountOfStars;
            CountryName = hotel.Country.Name;
            HotelImage = hotel.Hotelimage.ToList().FirstOrDefault()?.ImageSource;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryName { get; set; }
        public byte[] HotelImage { get; set; }

    }
}
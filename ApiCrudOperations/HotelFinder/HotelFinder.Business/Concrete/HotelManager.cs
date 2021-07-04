using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Concrete
{
    
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int Id)
        {
            _hotelRepository.DeleteHotel(Id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int Id)
        {
            if (Id>0)
            {
                return _hotelRepository.GetHotelById(Id);
            }
            else
            {
                throw new Exception("Id can not be less than 1");
            }
            
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }


    }
}

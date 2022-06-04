﻿using ThingsToReturn.Models;
using ThingsToReturn.ViewModels;

namespace ThingsToReturn.Extension;

public static class Extender
{
    public static IQueryable<AddressVM> ToModel(this IQueryable<Address> addresses)
    {
        return addresses.Select(a => new AddressVM
        {
            Country = a.Country,
            City = a.City,
            ZipCode = a.ZipCode, 
            Street = a.Street,
            BuildingNr = a.BuildingNr,

        });
    }
}
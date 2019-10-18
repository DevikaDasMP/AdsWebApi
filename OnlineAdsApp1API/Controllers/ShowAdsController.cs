using Exceptions;
using OnlineAdsAppBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineAdsApp1API.Controllers
{
    public class ShowAdsController : ApiController
    {
        public IHttpActionResult Index()
        {
            try
            {

                var ad = new AdsService();
                var adverts = ad.DisplayAllAds().ToList();

                List<AdvertisementViewModel> advertisements = new List<AdvertisementViewModel>();
                foreach (var item in adverts)
                {
                    advertisements.Add(new AdvertisementViewModel()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        Location = item.Location,
                        MinSellingPrice = item.MinSellingPrice,
                        MaxSellingPrice = item.MaxSellingPrice,
                        CreationDate = item.CreationDate,
                        ExpirationDate = item.ExpirationDate
                    });
                }
                if (advertisements != null)
                {
                    return Ok(advertisements);
                }

            }
            catch (Exception ex)
            {
                throw new OnlineAdsAppException("The ads cannot be displayed");
            }
            return InternalServerError();
        }
    }
}
